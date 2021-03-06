﻿using Binance.Orders;

namespace Binance.Api.WebSocket.Events
{
    public sealed class OrderUpdateEventArgs : ExecutionEventArgs, IChronological
    {
        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="timestamp">The event time.</param>
        /// <param name="order">The order.</param>
        /// <param name="executionType">The order execution type.</param>
        /// <param name="newClientOrderId">The new client order ID.</param>
        public OrderUpdateEventArgs(long timestamp, Order order, OrderExecutionType executionType, OrderRejectedReason rejectedReason, string newClientOrderId)
            : base(timestamp, order, executionType, rejectedReason, newClientOrderId)
        { }

        #endregion Constructors
    }
}
