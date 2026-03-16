// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption23Choice.Code))]
    [KnownType(typeof(CorporateActionOption23Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption23Choice.Code),
        nameof(CorporateActionOption23Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption23Choice.Proprietary),
        nameof(CorporateActionOption23Choice.Proprietary)
    )]
    [IsoId("_cfsr6ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Option 23 Choice")]
    public abstract record CorporateActionOption23Choice_ { }
}
