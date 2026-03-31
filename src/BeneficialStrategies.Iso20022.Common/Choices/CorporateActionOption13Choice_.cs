// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption13Choice.Code))]
    [KnownType(typeof(CorporateActionOption13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption13Choice.Code),
        nameof(CorporateActionOption13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption13Choice.Proprietary),
        nameof(CorporateActionOption13Choice.Proprietary)
    )]
    [IsoId("_wyvtIQrAEeGFLZ_5tFfOnw")]
    [DisplayName("Corporate Action Option 13 Choice")]
    public abstract record CorporateActionOption13Choice_ { }
}
