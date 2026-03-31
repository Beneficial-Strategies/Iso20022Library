// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of thesecurities movement.
    /// </summary>
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Amount))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Cash))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Currency))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Excluded))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Future))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Pending))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.ManuallyAccepted))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Eligibility))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Tax))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Wait))]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Amount),
        nameof(SecuritiesMovementStatus1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Cash),
        nameof(SecuritiesMovementStatus1Choice.Cash)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Currency),
        nameof(SecuritiesMovementStatus1Choice.Currency)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Excluded),
        nameof(SecuritiesMovementStatus1Choice.Excluded)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Future),
        nameof(SecuritiesMovementStatus1Choice.Future)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Pending),
        nameof(SecuritiesMovementStatus1Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.ManuallyAccepted),
        nameof(SecuritiesMovementStatus1Choice.ManuallyAccepted)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Eligibility),
        nameof(SecuritiesMovementStatus1Choice.Eligibility)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Tax),
        nameof(SecuritiesMovementStatus1Choice.Tax)
    )]
    [JsonDerivedType(
        typeof(SecuritiesMovementStatus1Choice.Wait),
        nameof(SecuritiesMovementStatus1Choice.Wait)
    )]
    [IsoId("_IeQt0OCzEei2UYJ62ws-Fw")]
    [DisplayName("Securities Movement Status 1 Choice")]
    public abstract record SecuritiesMovementStatus1Choice_ { }
}
