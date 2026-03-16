// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification Reference15Choice.
    /// </summary>
    [KnownType(typeof(IdentificationReference15Choice.AllocationIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.BlockIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.ClientOrderLinkIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.CollateralTransactionIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.CommonIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.ComplianceIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.ExecutingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.IndexIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.IndividualAllocationIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.InstructingPartyTransactionIdentification))]
    [KnownType(
        typeof(IdentificationReference15Choice.MarketInfrastructureTransactionIdentification)
    )]
    [KnownType(typeof(IdentificationReference15Choice.PoolIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.SecondaryAllocationIdentification))]
    [KnownType(typeof(IdentificationReference15Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.AllocationIdentification),
        nameof(IdentificationReference15Choice.AllocationIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.BlockIdentification),
        nameof(IdentificationReference15Choice.BlockIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.ClientOrderLinkIdentification),
        nameof(IdentificationReference15Choice.ClientOrderLinkIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.CollateralTransactionIdentification),
        nameof(IdentificationReference15Choice.CollateralTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.CommonIdentification),
        nameof(IdentificationReference15Choice.CommonIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.ComplianceIdentification),
        nameof(IdentificationReference15Choice.ComplianceIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.ExecutingPartyTransactionIdentification),
        nameof(IdentificationReference15Choice.ExecutingPartyTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.IndexIdentification),
        nameof(IdentificationReference15Choice.IndexIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.IndividualAllocationIdentification),
        nameof(IdentificationReference15Choice.IndividualAllocationIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.InstructingPartyTransactionIdentification),
        nameof(IdentificationReference15Choice.InstructingPartyTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.MarketInfrastructureTransactionIdentification),
        nameof(IdentificationReference15Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.PoolIdentification),
        nameof(IdentificationReference15Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.SecondaryAllocationIdentification),
        nameof(IdentificationReference15Choice.SecondaryAllocationIdentification)
    )]
    [JsonDerivedType(
        typeof(IdentificationReference15Choice.UniqueTransactionIdentifier),
        nameof(IdentificationReference15Choice.UniqueTransactionIdentifier)
    )]
    [IsoId("_Bgvg24cGEe-6cOl7zMpJaA")]
    [DisplayName("Identification Reference15Choice")]
    public abstract record IdentificationReference15Choice_ { }
}
