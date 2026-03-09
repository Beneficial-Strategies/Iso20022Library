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
    [KnownType(typeof(IdentificationReference8Choice.InstructingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.ExecutingPartyTransactionIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.ClientOrderLinkIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.PoolIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.BlockIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.AllocationIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.IndividualAllocationIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.SecondaryAllocationIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.IndexIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.CommonIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.ComplianceIdentification))]
    [KnownType(typeof(IdentificationReference8Choice.CollateralTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationReference8Choice.InstructingPartyTransactionIdentification),nameof(IdentificationReference8Choice.InstructingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.ExecutingPartyTransactionIdentification),nameof(IdentificationReference8Choice.ExecutingPartyTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.MarketInfrastructureTransactionIdentification),nameof(IdentificationReference8Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.ClientOrderLinkIdentification),nameof(IdentificationReference8Choice.ClientOrderLinkIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.PoolIdentification),nameof(IdentificationReference8Choice.PoolIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.BlockIdentification),nameof(IdentificationReference8Choice.BlockIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.AllocationIdentification),nameof(IdentificationReference8Choice.AllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.IndividualAllocationIdentification),nameof(IdentificationReference8Choice.IndividualAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.SecondaryAllocationIdentification),nameof(IdentificationReference8Choice.SecondaryAllocationIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.IndexIdentification),nameof(IdentificationReference8Choice.IndexIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.CommonIdentification),nameof(IdentificationReference8Choice.CommonIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.ComplianceIdentification),nameof(IdentificationReference8Choice.ComplianceIdentification))]
    [JsonDerivedType(typeof(IdentificationReference8Choice.CollateralTransactionIdentification),nameof(IdentificationReference8Choice.CollateralTransactionIdentification))]
    #endif
    [IsoId("_AcF7kdokEeC60axPepSq7g_1350300624")]
    [DisplayName("Identification Reference 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationReference8Choice_
    #else
    public abstract partial class IdentificationReference8Choice_
    #endif
    {
    }
}
