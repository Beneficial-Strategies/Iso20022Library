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
    /// Provides details about the agreed amount for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(AgreedAmount1Choice.AgreedAmountDetails))]
    [KnownType(typeof(AgreedAmount1Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AgreedAmount1Choice.AgreedAmountDetails),nameof(AgreedAmount1Choice.AgreedAmountDetails))]
    [JsonDerivedType(typeof(AgreedAmount1Choice.SegregatedIndependentAmount),nameof(AgreedAmount1Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_Qm7bJdp-Ed-ak6NoX_4Aeg_926398968")]
    [DisplayName("Agreed Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AgreedAmount1Choice_
    #else
    public abstract partial class AgreedAmount1Choice_
    #endif
    {
    }
}
