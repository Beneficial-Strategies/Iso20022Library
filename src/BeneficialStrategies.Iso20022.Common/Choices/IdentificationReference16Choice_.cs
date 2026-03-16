// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification Reference16Choice.
    /// </summary>
    [KnownType(typeof(IdentificationReference16Choice.AllocationIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.BlockIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.CancellationRequestIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.ClientOrderLinkIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.CollateralTransactionIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.CommonIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.ComplianceIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.ExecutingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.IndexIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.IndividualAllocationIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.InstructingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.PoolIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.SecondaryAllocationIdentification))]
    [KnownType(typeof(IdentificationReference16Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.AllocationIdentification),nameof(IdentificationReference16Choice.AllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.BlockIdentification),nameof(IdentificationReference16Choice.BlockIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.CancellationRequestIdentification),nameof(IdentificationReference16Choice.CancellationRequestIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.ClientOrderLinkIdentification),nameof(IdentificationReference16Choice.ClientOrderLinkIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.CollateralTransactionIdentification),nameof(IdentificationReference16Choice.CollateralTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.CommonIdentification),nameof(IdentificationReference16Choice.CommonIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.ComplianceIdentification),nameof(IdentificationReference16Choice.ComplianceIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.ExecutingPartyTransactionIdentification),nameof(IdentificationReference16Choice.ExecutingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.IndexIdentification),nameof(IdentificationReference16Choice.IndexIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.IndividualAllocationIdentification),nameof(IdentificationReference16Choice.IndividualAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.InstructingPartyTransactionIdentification),nameof(IdentificationReference16Choice.InstructingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.MarketInfrastructureTransactionIdentification),nameof(IdentificationReference16Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.PoolIdentification),nameof(IdentificationReference16Choice.PoolIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.SecondaryAllocationIdentification),nameof(IdentificationReference16Choice.SecondaryAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference16Choice.UniqueTransactionIdentifier),nameof(IdentificationReference16Choice.UniqueTransactionIdentifier))]
    [IsoId("_Qs7-O4cGEe-6cOl7zMpJaA")]
    [DisplayName("Identification Reference16Choice")]
    public abstract partial record IdentificationReference16Choice_
    {
    }
}
