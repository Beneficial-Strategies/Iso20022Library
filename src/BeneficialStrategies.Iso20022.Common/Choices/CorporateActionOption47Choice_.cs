// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption47Choice.Code))]
    [KnownType(typeof(CorporateActionOption47Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption47Choice.Code), nameof(CorporateActionOption47Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption47Choice.Proprietary), nameof(CorporateActionOption47Choice.Proprietary))]
    [IsoId("_RWX8oQ7VEfC-6PbsYHIdig")]
    [DisplayName("Corporate Action Option 47 Choice")]
    public abstract record CorporateActionOption47Choice_ { }
}
