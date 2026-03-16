// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action stage.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage4Choice.Code))]
    [KnownType(typeof(CorporateActionEventStage4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventStage4Choice.Code),
        nameof(CorporateActionEventStage4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventStage4Choice.Proprietary),
        nameof(CorporateActionEventStage4Choice.Proprietary)
    )]
    [IsoId("_8Qbo0ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Stage 4 Choice")]
    public abstract record CorporateActionEventStage4Choice_ { }
}
