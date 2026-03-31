// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption10Choice.Code))]
    [KnownType(typeof(CorporateActionOption10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption10Choice.Code),
        nameof(CorporateActionOption10Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption10Choice.Proprietary),
        nameof(CorporateActionOption10Choice.Proprietary)
    )]
    [IsoId("_1-Ji1_ogEeC7qvRLUh5UBA")]
    [DisplayName("Corporate Action Option 10 Choice")]
    public abstract record CorporateActionOption10Choice_ { }
}
