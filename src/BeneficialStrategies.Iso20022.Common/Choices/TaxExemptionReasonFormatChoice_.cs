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
    [KnownType(typeof(TaxExemptionReasonFormatChoice.Unstructured))]
    [KnownType(typeof(TaxExemptionReasonFormatChoice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxExemptionReasonFormatChoice.Unstructured),nameof(TaxExemptionReasonFormatChoice.Unstructured))]
    [JsonDerivedType(typeof(TaxExemptionReasonFormatChoice.Structured),nameof(TaxExemptionReasonFormatChoice.Structured))]
    #endif
    [IsoId("_UzJj8tp-Ed-ak6NoX_4Aeg_-1748201270")]
    [DisplayName("Tax Exemption Reason Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxExemptionReasonFormatChoice_
    #else
    public abstract partial class TaxExemptionReasonFormatChoice_
    #endif
    {
    }
}
