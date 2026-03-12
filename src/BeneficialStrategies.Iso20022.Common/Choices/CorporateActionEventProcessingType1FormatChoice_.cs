// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of event processing.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType1FormatChoice.Code),nameof(CorporateActionEventProcessingType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType1FormatChoice.Proprietary),nameof(CorporateActionEventProcessingType1FormatChoice.Proprietary))]
    [IsoId("_RmHAMdp-Ed-ak6NoX_4Aeg_699190436")]
    [DisplayName("Corporate Action Event Processing Type 1 Format Choice")]
    public abstract partial record CorporateActionEventProcessingType1FormatChoice_
    {
    }
}
