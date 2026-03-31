// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption39Choice.Code))]
    [KnownType(typeof(CorporateActionOption39Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption39Choice.Code),
        nameof(CorporateActionOption39Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption39Choice.Proprietary),
        nameof(CorporateActionOption39Choice.Proprietary)
    )]
    [IsoId("_-lke5gVSEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Option 39 Choice")]
    public abstract record CorporateActionOption39Choice_ { }
}
