﻿namespace PureDelivery.Shared.Contracts.Domain.Enums;

public enum PaymentStatus
{
    Pending = 0,
    Processing = 1,
    Completed = 2,
    Failed = 3,
    Refunded = 4
}