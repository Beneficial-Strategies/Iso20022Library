// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption33Choice.Code))]
    [KnownType(typeof(CorporateActionOption33Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption33Choice.Code),
        nameof(CorporateActionOption33Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption33Choice.Proprietary),
        nameof(CorporateActionOption33Choice.Proprietary)
    )]
    [IsoId("_w9gyo-asEemtTOaHuc_63w")]
    [DisplayName("Corporate Action Option 33 Choice")]
    public abstract record CorporateActionOption33Choice_ { }
}
