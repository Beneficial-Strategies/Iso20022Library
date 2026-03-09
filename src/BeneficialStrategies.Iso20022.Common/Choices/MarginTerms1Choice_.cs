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
    /// Provides the margin terms for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginTerms1Choice.MarginDetails))]
    [KnownType(typeof(MarginTerms1Choice.SegregatedIndependentAmountMargin))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginTerms1Choice.MarginDetails),nameof(MarginTerms1Choice.MarginDetails))]
    [JsonDerivedType(typeof(MarginTerms1Choice.SegregatedIndependentAmountMargin),nameof(MarginTerms1Choice.SegregatedIndependentAmountMargin))]
    #endif
    [IsoId("_QmogMtp-Ed-ak6NoX_4Aeg_86732419")]
    [DisplayName("Margin Terms 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginTerms1Choice_
    #else
    public abstract partial class MarginTerms1Choice_
    #endif
    {
    }
}
