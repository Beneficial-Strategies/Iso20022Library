// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action stage.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage3Choice.Code))]
    [KnownType(typeof(CorporateActionEventStage3Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStage3Choice.Code),nameof(CorporateActionEventStage3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStage3Choice.Proprietary),nameof(CorporateActionEventStage3Choice.Proprietary))]
    [IsoId("_RCKigTqqEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Stage 3 Choice")]
    public abstract partial record CorporateActionEventStage3Choice_
    {
    }
}
