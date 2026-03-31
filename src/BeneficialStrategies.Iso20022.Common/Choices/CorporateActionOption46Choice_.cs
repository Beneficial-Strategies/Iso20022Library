// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption46Choice.Code))]
    [KnownType(typeof(CorporateActionOption46Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption46Choice.Code),
        nameof(CorporateActionOption46Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption46Choice.Proprietary),
        nameof(CorporateActionOption46Choice.Proprietary)
    )]
    [IsoId("_ZHey_x9REeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Option 46 Choice")]
    public abstract record CorporateActionOption46Choice_ { }
}
