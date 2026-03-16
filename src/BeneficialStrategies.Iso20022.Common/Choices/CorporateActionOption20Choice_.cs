// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption20Choice.Code))]
    [KnownType(typeof(CorporateActionOption20Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption20Choice.Code),
        nameof(CorporateActionOption20Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption20Choice.Proprietary),
        nameof(CorporateActionOption20Choice.Proprietary)
    )]
    [IsoId("_xbrNv0GTEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Option 20 Choice")]
    public abstract record CorporateActionOption20Choice_ { }
}
