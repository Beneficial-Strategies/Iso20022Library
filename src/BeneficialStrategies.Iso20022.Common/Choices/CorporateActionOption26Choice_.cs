// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption26Choice.Code))]
    [KnownType(typeof(CorporateActionOption26Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption26Choice.Code),nameof(CorporateActionOption26Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption26Choice.Proprietary),nameof(CorporateActionOption26Choice.Proprietary))]
    [IsoId("_cj7rB5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Option 26 Choice")]
    public abstract partial record CorporateActionOption26Choice_
    {
    }
}
