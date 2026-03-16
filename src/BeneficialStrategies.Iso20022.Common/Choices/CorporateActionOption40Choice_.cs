// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption40Choice.Code))]
    [KnownType(typeof(CorporateActionOption40Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption40Choice.Code),
        nameof(CorporateActionOption40Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption40Choice.Proprietary),
        nameof(CorporateActionOption40Choice.Proprietary)
    )]
    [IsoId("_EypLge35Eeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action Option 40 Choice")]
    public abstract record CorporateActionOption40Choice_ { }
}
