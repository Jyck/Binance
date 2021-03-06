﻿namespace Binance.Orders
{
    public class LimitOrder : ClientOrder
    {
        #region Public Properties

        /// <summary>
        /// Get the order type.
        /// </summary>
        public override OrderType Type => OrderType.Limit;

        /// <summary>
        /// Get or set the price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Get or set the time in force.
        /// </summary>
        public TimeInForce TimeInForce { get; set; }

        #endregion Public Properties
    }
}
