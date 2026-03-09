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
    /// Choice to provide the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginCallResult1Choice.MarginCallResultDetails))]
    [KnownType(typeof(MarginCallResult1Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginCallResult1Choice.MarginCallResultDetails),nameof(MarginCallResult1Choice.MarginCallResultDetails))]
    [JsonDerivedType(typeof(MarginCallResult1Choice.SegregatedIndependentAmount),nameof(MarginCallResult1Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_QmevNdp-Ed-ak6NoX_4Aeg_98969044")]
    [DisplayName("Margin Call Result 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginCallResult1Choice_
    #else
    public abstract partial class MarginCallResult1Choice_
    #endif
    {
    }
}
