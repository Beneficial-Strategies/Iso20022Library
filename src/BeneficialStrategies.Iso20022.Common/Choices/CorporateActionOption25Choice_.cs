// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption25Choice.Code))]
    [KnownType(typeof(CorporateActionOption25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption25Choice.Code),
        nameof(CorporateActionOption25Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption25Choice.Proprietary),
        nameof(CorporateActionOption25Choice.Proprietary)
    )]
    [IsoId("_chdmO5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Option 25 Choice")]
    public abstract record CorporateActionOption25Choice_ { }
}
