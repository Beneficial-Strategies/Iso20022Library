// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption11Choice.Code))]
    [KnownType(typeof(CorporateActionOption11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption11Choice.Code),
        nameof(CorporateActionOption11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption11Choice.Proprietary),
        nameof(CorporateActionOption11Choice.Proprietary)
    )]
    [IsoId("_onpwcQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Corporate Action Option 11 Choice")]
    public abstract record CorporateActionOption11Choice_ { }
}
