﻿using Binance.Orders;
using System;

namespace Binance
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert string to <see cref="KlineInterval"/>.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns></returns>
        public static KlineInterval ToKlineInterval(this string s)
        {
            Throw.IfNullOrWhiteSpace(s, nameof(s));

            switch (s.Trim().ToLower())
            {
                case "1m": return KlineInterval.Minute;
                case "3m": return KlineInterval.Minutes_3;
                case "5m": return KlineInterval.Minutes_5;
                case "15m": return KlineInterval.Minutes_15;
                case "30m": return KlineInterval.Minutes_30;
                case "60m":
                case "1h": return KlineInterval.Hour;
                case "2h": return KlineInterval.Hours_2;
                case "4h": return KlineInterval.Hours_4;
                case "8h": return KlineInterval.Hours_8;
                case "12h": return KlineInterval.Hours_12;
                case "24h":
                case "1d": return KlineInterval.Day;
                case "3d": return KlineInterval.Days_3;
                case "1w": return KlineInterval.Week;
                case "1M": return KlineInterval.Month;
                default:
                    throw new ArgumentException($"{nameof(ToKlineInterval)}: interval not supported: {s}");
            }
        }

        /// <summary>
        /// Try to transform a symbol string to an acceptable format.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        internal static string FixSymbol(this string symbol)
        {
            Throw.IfNullOrWhiteSpace(symbol);

            return symbol.Trim().Replace(" ", string.Empty).Replace("-", string.Empty).Replace("_", string.Empty).Replace("/", string.Empty).ToUpper();
        }

        /// <summary>
        /// Return true if string is a JSON object.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal static bool IsJsonObject(this string s)
        {
            return !string.IsNullOrWhiteSpace(s)
                && s.StartsWith("{") && s.EndsWith("}");
        }

        /// <summary>
        /// Deserialize order status.
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        internal static OrderStatus ConvertOrderStatus(this string status)
        {
            switch (status)
            {
                case "NEW": return OrderStatus.New;
                case "PARTIALLY_FILLED": return OrderStatus.PartiallyFilled;
                case "FILLED": return OrderStatus.Filled;
                case "CANCELED": return OrderStatus.Canceled;
                case "PENDING_CANCEL": return OrderStatus.PendingCancel;
                case "REJECTED": return OrderStatus.Rejected;
                case "EXPIRED": return OrderStatus.Expired;
                default:
                    throw new Exception($"Failed to convert order status: \"{status}\"");
            }
        }

        /// <summary>
        /// Deserialize order type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static OrderType ConvertOrderType(this string type)
        {
            switch (type)
            {
                case "LIMIT": return OrderType.Limit;
                case "MARKET": return OrderType.Market;
                default:
                    throw new Exception($"Failed to convert order type: \"{type}\"");
            }
        }

        /// <summary>
        /// Deserialize order side.
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        internal static OrderSide ConvertOrderSide(this string side)
        {
            switch (side)
            {
                case "BUY": return OrderSide.Buy;
                case "SELL": return OrderSide.Sell;
                default:
                    throw new Exception($"Failed to convert order side: \"{side}\"");
            }
        }

        /// <summary>
        /// Deserialize time in force.
        /// </summary>
        /// <param name="timeInForce"></param>
        /// <returns></returns>
        internal static TimeInForce ConvertTimeInForce(this string timeInForce)
        {
            switch (timeInForce)
            {
                case "GTC": return TimeInForce.GTC;
                case "IOC": return TimeInForce.IOC;
                default:
                    throw new Exception($"Failed to convert time in force: \"{timeInForce}\"");
            }
        }
    }
}
