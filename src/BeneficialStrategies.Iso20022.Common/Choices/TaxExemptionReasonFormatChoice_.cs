// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between specification of the tax exemption reason in structured or free text format.
    /// </summary>
    [KnownType(typeof(TaxExemptionReasonFormatChoice.Unstructured))]
    [KnownType(typeof(TaxExemptionReasonFormatChoice.Structured))]
    [JsonDerivedType(
        typeof(TaxExemptionReasonFormatChoice.Unstructured),
        nameof(TaxExemptionReasonFormatChoice.Unstructured)
    )]
    [JsonDerivedType(
        typeof(TaxExemptionReasonFormatChoice.Structured),
        nameof(TaxExemptionReasonFormatChoice.Structured)
    )]
    [IsoId("_UzJj8tp-Ed-ak6NoX_4Aeg_-1748201270")]
    [DisplayName("Tax Exemption Reason Format Choice")]
    public abstract record TaxExemptionReasonFormatChoice_ { }
}
