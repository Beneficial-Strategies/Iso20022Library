// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption37Choice.Code))]
    [KnownType(typeof(CorporateActionOption37Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption37Choice.Code),
        nameof(CorporateActionOption37Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption37Choice.Proprietary),
        nameof(CorporateActionOption37Choice.Proprietary)
    )]
    [IsoId("_5ih0Ge32Eeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action Option 37 Choice")]
    public abstract record CorporateActionOption37Choice_ { }
}
