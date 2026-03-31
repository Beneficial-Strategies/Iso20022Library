// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption41Choice.Code))]
    [KnownType(typeof(CorporateActionOption41Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption41Choice.Code),
        nameof(CorporateActionOption41Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption41Choice.Proprietary),
        nameof(CorporateActionOption41Choice.Proprietary)
    )]
    [IsoId("_ifEYge35Eeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action Option 41 Choice")]
    public abstract record CorporateActionOption41Choice_ { }
}
