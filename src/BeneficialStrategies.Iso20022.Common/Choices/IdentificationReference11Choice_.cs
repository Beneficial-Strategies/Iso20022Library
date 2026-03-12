// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of a document, message or transaction.
    /// </summary>
    [KnownType(typeof(IdentificationReference11Choice.InstructingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.ExecutingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.ClientOrderLinkIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.PoolIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.BlockIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.AllocationIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.IndividualAllocationIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.SecondaryAllocationIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.IndexIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.CommonIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.ComplianceIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.CancellationRequestIdentification))]
    [KnownType(typeof(IdentificationReference11Choice.CollateralTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.InstructingPartyTransactionIdentification),nameof(IdentificationReference11Choice.InstructingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.ExecutingPartyTransactionIdentification),nameof(IdentificationReference11Choice.ExecutingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.MarketInfrastructureTransactionIdentification),nameof(IdentificationReference11Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.ClientOrderLinkIdentification),nameof(IdentificationReference11Choice.ClientOrderLinkIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.PoolIdentification),nameof(IdentificationReference11Choice.PoolIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.BlockIdentification),nameof(IdentificationReference11Choice.BlockIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.AllocationIdentification),nameof(IdentificationReference11Choice.AllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.IndividualAllocationIdentification),nameof(IdentificationReference11Choice.IndividualAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.SecondaryAllocationIdentification),nameof(IdentificationReference11Choice.SecondaryAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.IndexIdentification),nameof(IdentificationReference11Choice.IndexIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.CommonIdentification),nameof(IdentificationReference11Choice.CommonIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.ComplianceIdentification),nameof(IdentificationReference11Choice.ComplianceIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.CancellationRequestIdentification),nameof(IdentificationReference11Choice.CancellationRequestIdentification))]
    [JsonDerivedType(typeof(IdentificationReference11Choice.CollateralTransactionIdentification),nameof(IdentificationReference11Choice.CollateralTransactionIdentification))]
    [IsoId("_AdlJUtokEeC60axPepSq7g_197856577")]
    [DisplayName("Identification Reference 11 Choice")]
    public abstract partial record IdentificationReference11Choice_
    {
    }
}
