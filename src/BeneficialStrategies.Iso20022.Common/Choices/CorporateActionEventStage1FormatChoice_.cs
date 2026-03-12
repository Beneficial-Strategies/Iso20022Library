// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the stage of the CA event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventStage1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStage1FormatChoice.Code),nameof(CorporateActionEventStage1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStage1FormatChoice.Proprietary),nameof(CorporateActionEventStage1FormatChoice.Proprietary))]
    [IsoId("_RmHANNp-Ed-ak6NoX_4Aeg_-299884544")]
    [DisplayName("Corporate Action Event Stage 1 Format Choice")]
    public abstract partial record CorporateActionEventStage1FormatChoice_
    {
    }
}
