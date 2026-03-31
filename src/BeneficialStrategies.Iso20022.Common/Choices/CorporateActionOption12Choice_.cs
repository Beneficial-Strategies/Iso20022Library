// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption12Choice.Code))]
    [KnownType(typeof(CorporateActionOption12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption12Choice.Code),
        nameof(CorporateActionOption12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption12Choice.Proprietary),
        nameof(CorporateActionOption12Choice.Proprietary)
    )]
    [IsoId("_bhUW4QrAEeGFLZ_5tFfOnw")]
    [DisplayName("Corporate Action Option 12 Choice")]
    public abstract record CorporateActionOption12Choice_ { }
}
