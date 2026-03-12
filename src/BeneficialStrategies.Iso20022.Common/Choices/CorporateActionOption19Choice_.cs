// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption19Choice.Code))]
    [KnownType(typeof(CorporateActionOption19Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption19Choice.Code),nameof(CorporateActionOption19Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption19Choice.Proprietary),nameof(CorporateActionOption19Choice.Proprietary))]
    [IsoId("_yWuaY0GLEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Option 19 Choice")]
    public abstract partial record CorporateActionOption19Choice_
    {
    }
}
