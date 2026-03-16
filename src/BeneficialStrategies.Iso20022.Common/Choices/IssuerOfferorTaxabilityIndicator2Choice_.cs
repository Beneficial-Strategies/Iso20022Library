// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Issuer Offeror Taxability Indicator2Choice.
    /// </summary>
    [KnownType(typeof(IssuerOfferorTaxabilityIndicator2Choice.Code))]
    [KnownType(typeof(IssuerOfferorTaxabilityIndicator2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IssuerOfferorTaxabilityIndicator2Choice.Code),
        nameof(IssuerOfferorTaxabilityIndicator2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IssuerOfferorTaxabilityIndicator2Choice.Proprietary),
        nameof(IssuerOfferorTaxabilityIndicator2Choice.Proprietary)
    )]
    [IsoId("_2VuJw6GnEe-4O7NbwmwJkQ")]
    [DisplayName("Issuer Offeror Taxability Indicator2Choice")]
    public abstract record IssuerOfferorTaxabilityIndicator2Choice_ { }
}
