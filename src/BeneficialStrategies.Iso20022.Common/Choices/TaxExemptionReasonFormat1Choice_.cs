// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between specification of the tax exemption reason in structured or free text format.
    /// </summary>
    [KnownType(typeof(TaxExemptionReasonFormat1Choice.Unstructured))]
    [KnownType(typeof(TaxExemptionReasonFormat1Choice.Structured))]
    [JsonDerivedType(
        typeof(TaxExemptionReasonFormat1Choice.Unstructured),
        nameof(TaxExemptionReasonFormat1Choice.Unstructured)
    )]
    [JsonDerivedType(
        typeof(TaxExemptionReasonFormat1Choice.Structured),
        nameof(TaxExemptionReasonFormat1Choice.Structured)
    )]
    [IsoId("_4V_rQe5oEemXBpiFxCCWFQ")]
    [DisplayName("Tax Exemption Reason Format 1 Choice")]
    public abstract record TaxExemptionReasonFormat1Choice_ { }
}
