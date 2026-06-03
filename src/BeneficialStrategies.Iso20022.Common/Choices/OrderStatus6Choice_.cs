// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of status for an order.</summary>
    [IsoId("a87fc454-7278-4917-ba9d-bc074fd4b496")]
    [DisplayName("Order Status 6 Choice")]
    [KnownType(typeof(Status))]
    [JsonDerivedType(typeof(Status), nameof(Status))]
    [KnownType(typeof(Cancelled))]
    [JsonDerivedType(typeof(Cancelled), nameof(Cancelled))]
    [KnownType(typeof(ConditionallyAccepted))]
    [JsonDerivedType(typeof(ConditionallyAccepted), nameof(ConditionallyAccepted))]
    [KnownType(typeof(Rejected))]
    [JsonDerivedType(typeof(Rejected), nameof(Rejected))]
    [KnownType(typeof(Suspended))]
    [JsonDerivedType(typeof(Suspended), nameof(Suspended))]
    [KnownType(typeof(InRepair))]
    [JsonDerivedType(typeof(InRepair), nameof(InRepair))]
    [KnownType(typeof(PartiallySettled))]
    [JsonDerivedType(typeof(PartiallySettled), nameof(PartiallySettled))]
    public abstract record OrderStatus6Choice_;
}
