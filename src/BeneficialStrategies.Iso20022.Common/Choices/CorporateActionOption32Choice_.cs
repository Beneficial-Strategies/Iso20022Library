// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption32Choice.Code))]
    [KnownType(typeof(CorporateActionOption32Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption32Choice.Code),nameof(CorporateActionOption32Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption32Choice.Proprietary),nameof(CorporateActionOption32Choice.Proprietary))]
    [IsoId("_ZPbM8easEemtTOaHuc_63w")]
    [DisplayName("Corporate Action Option 32 Choice")]
    public abstract partial record CorporateActionOption32Choice_
    {
    }
}
