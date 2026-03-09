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
    /// Provides the margin requirements for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginRequirement1Choice.MarginRequirement))]
    [KnownType(typeof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginRequirement1Choice.MarginRequirement),nameof(MarginRequirement1Choice.MarginRequirement))]
    [JsonDerivedType(typeof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement),nameof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement))]
    #endif
    [IsoId("_QmevONp-Ed-ak6NoX_4Aeg_-593475226")]
    [DisplayName("Margin Requirement 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginRequirement1Choice_
    #else
    public abstract partial class MarginRequirement1Choice_
    #endif
    {
    }
}
