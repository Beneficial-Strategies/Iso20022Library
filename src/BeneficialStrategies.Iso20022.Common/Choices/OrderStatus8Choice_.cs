// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of status for an order.</summary>
    [IsoId("e7ceb94c-85b9-4fff-aa35-b376c13d7790")]
    [DisplayName("Order Status 8 Choice")]
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
    [KnownType(typeof(PartiallySettled))]
    [JsonDerivedType(typeof(PartiallySettled), nameof(PartiallySettled))]
    public abstract record OrderStatus8Choice_;
}
