// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption35Choice.Code))]
    [KnownType(typeof(CorporateActionOption35Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption35Choice.Code),nameof(CorporateActionOption35Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption35Choice.Proprietary),nameof(CorporateActionOption35Choice.Proprietary))]
    [IsoId("_yqZXvgVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Option 35 Choice")]
    public abstract partial record CorporateActionOption35Choice_
    {
    }
}
