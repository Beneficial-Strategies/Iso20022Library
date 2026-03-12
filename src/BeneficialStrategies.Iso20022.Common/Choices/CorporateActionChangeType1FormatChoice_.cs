// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of changes.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionChangeType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionChangeType1FormatChoice.Code),nameof(CorporateActionChangeType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeType1FormatChoice.Proprietary),nameof(CorporateActionChangeType1FormatChoice.Proprietary))]
    [IsoId("_Rl9PNtp-Ed-ak6NoX_4Aeg_-146388602")]
    [DisplayName("Corporate Action Change Type 1 Format Choice")]
    public abstract partial record CorporateActionChangeType1FormatChoice_
    {
    }
}
