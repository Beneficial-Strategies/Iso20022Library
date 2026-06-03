// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of status for an order.</summary>
    [IsoId("e4f51f88-5986-4f63-a9a2-b369ad502152")]
    [DisplayName("Order Status 7 Choice")]
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
    public abstract record OrderStatus7Choice_;
}
