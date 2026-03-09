// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
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
    #endif
    [IsoId("_AdlJUtokEeC60axPepSq7g_197856577")]
    [DisplayName("Identification Reference 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationReference11Choice_
    #else
    public abstract partial class IdentificationReference11Choice_
    #endif
    {
    }
}
