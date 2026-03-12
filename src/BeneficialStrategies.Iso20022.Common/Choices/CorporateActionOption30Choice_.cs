// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption30Choice.Code))]
    [KnownType(typeof(CorporateActionOption30Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption30Choice.Code),nameof(CorporateActionOption30Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption30Choice.Proprietary),nameof(CorporateActionOption30Choice.Proprietary))]
    [IsoId("_w0x_X-aqEemtTOaHuc_63w")]
    [DisplayName("Corporate Action Option 30 Choice")]
    public abstract partial record CorporateActionOption30Choice_
    {
    }
}
