// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption21Choice.Code))]
    [KnownType(typeof(CorporateActionOption21Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption21Choice.Code),
        nameof(CorporateActionOption21Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption21Choice.Proprietary),
        nameof(CorporateActionOption21Choice.Proprietary)
    )]
    [IsoId("_Q1QDIUGVEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Option 21 Choice")]
    public abstract record CorporateActionOption21Choice_ { }
}
