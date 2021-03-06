﻿namespace Binance.Orders
{
    public abstract class ClientOrder : IChronological
    {
        #region Public Properties

        /// <summary>
        /// Get the order type.
        /// </summary>
        public abstract OrderType Type { get; }

        /// <summary>
        /// Get or set the order side.
        /// </summary>
        public OrderSide Side { get; set; }

        /// <summary>
        /// Get or set the client order ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Get or set the symbol.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Get or set the stop price.
        /// </summary>
        public decimal StopPrice { get; set; }

        /// <summary>
        /// Get or set the quantity.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Get or set the iceberg quantity.
        /// </summary>
        public decimal IcebergQuantity { get; set; }

        /// <summary>
        /// Get or set the flag for test only placement.
        /// </summary>
        public bool IsTestOnly { get; set; }

        /// <summary>
        /// Get the transact time.
        /// </summary>
        public long Timestamp { get; internal set; }

        #endregion Public Properties
    }
}
