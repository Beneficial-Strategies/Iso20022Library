// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption34Choice.Code))]
    [KnownType(typeof(CorporateActionOption34Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption34Choice.Code),
        nameof(CorporateActionOption34Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption34Choice.Proprietary),
        nameof(CorporateActionOption34Choice.Proprietary)
    )]
    [IsoId("_hwSAVwVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Option 34 Choice")]
    public abstract record CorporateActionOption34Choice_ { }
}
