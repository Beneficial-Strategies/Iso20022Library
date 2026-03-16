// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption29Choice.Code))]
    [KnownType(typeof(CorporateActionOption29Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption29Choice.Code),
        nameof(CorporateActionOption29Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption29Choice.Proprietary),
        nameof(CorporateActionOption29Choice.Proprietary)
    )]
    [IsoId("_VyjHFZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Corporate Action Option 29 Choice")]
    public abstract record CorporateActionOption29Choice_ { }
}
