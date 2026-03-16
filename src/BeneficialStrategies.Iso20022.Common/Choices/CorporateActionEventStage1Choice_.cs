// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action stage.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage1Choice.Code))]
    [KnownType(typeof(CorporateActionEventStage1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventStage1Choice.Code),
        nameof(CorporateActionEventStage1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventStage1Choice.Proprietary),
        nameof(CorporateActionEventStage1Choice.Proprietary)
    )]
    [IsoId("_Qsl-QNp-Ed-ak6NoX_4Aeg_526490390")]
    [DisplayName("Corporate Action Event Stage 1 Choice")]
    public abstract record CorporateActionEventStage1Choice_ { }
}
