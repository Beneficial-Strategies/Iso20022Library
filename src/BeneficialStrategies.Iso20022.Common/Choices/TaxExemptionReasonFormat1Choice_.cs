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
    /// Choice between specification of the tax exemption reason in structured or free text format.
    /// </summary>
    [KnownType(typeof(TaxExemptionReasonFormat1Choice.Unstructured))]
    [KnownType(typeof(TaxExemptionReasonFormat1Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxExemptionReasonFormat1Choice.Unstructured),nameof(TaxExemptionReasonFormat1Choice.Unstructured))]
    [JsonDerivedType(typeof(TaxExemptionReasonFormat1Choice.Structured),nameof(TaxExemptionReasonFormat1Choice.Structured))]
    #endif
    [IsoId("_4V_rQe5oEemXBpiFxCCWFQ")]
    [DisplayName("Tax Exemption Reason Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxExemptionReasonFormat1Choice_
    #else
    public abstract partial class TaxExemptionReasonFormat1Choice_
    #endif
    {
    }
}
