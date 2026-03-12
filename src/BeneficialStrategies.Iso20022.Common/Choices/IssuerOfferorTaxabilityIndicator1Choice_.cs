// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the issuer / offeror taxability status.
    /// </summary>
    [KnownType(typeof(IssuerOfferorTaxabilityIndicator1Choice.Code))]
    [KnownType(typeof(IssuerOfferorTaxabilityIndicator1Choice.Proprietary))]
    [JsonDerivedType(typeof(IssuerOfferorTaxabilityIndicator1Choice.Code),nameof(IssuerOfferorTaxabilityIndicator1Choice.Code))]
    [JsonDerivedType(typeof(IssuerOfferorTaxabilityIndicator1Choice.Proprietary),nameof(IssuerOfferorTaxabilityIndicator1Choice.Proprietary))]
    [IsoId("_DUEMcIlzEeavwKddCbm3hg")]
    [DisplayName("Issuer Offeror Taxability Indicator 1 Choice")]
    public abstract partial record IssuerOfferorTaxabilityIndicator1Choice_
    {
    }
}
