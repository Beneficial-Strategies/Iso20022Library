// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the tax exemption reason.
    /// </summary>
    [KnownType(typeof(TaxExemptionReason1Choice.Code))]
    [KnownType(typeof(TaxExemptionReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TaxExemptionReason1Choice.Code),
        nameof(TaxExemptionReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TaxExemptionReason1Choice.Proprietary),
        nameof(TaxExemptionReason1Choice.Proprietary)
    )]
    [IsoId("_jJ3P4xc-EeK5g-3oYI0_9Q")]
    [DisplayName("Tax Exemption Reason 1 Choice")]
    public abstract record TaxExemptionReason1Choice_ { }
}
