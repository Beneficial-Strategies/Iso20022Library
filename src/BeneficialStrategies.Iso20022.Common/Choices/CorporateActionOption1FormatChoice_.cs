// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(CorporateActionOption1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionOption1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption1FormatChoice.Code),nameof(CorporateActionOption1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption1FormatChoice.Proprietary),nameof(CorporateActionOption1FormatChoice.Proprietary))]
    [IsoId("_RlgjQNp-Ed-ak6NoX_4Aeg_-1178916842")]
    [DisplayName("Corporate Action Option 1 Format Choice")]
    public abstract partial record CorporateActionOption1FormatChoice_
    {
    }
}
