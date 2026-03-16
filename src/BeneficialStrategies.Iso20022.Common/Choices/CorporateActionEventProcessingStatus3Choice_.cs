// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of corporate action processing status.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingStatus3Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingStatus3Choice.Code),
        nameof(CorporateActionEventProcessingStatus3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventProcessingStatus3Choice.Proprietary),
        nameof(CorporateActionEventProcessingStatus3Choice.Proprietary)
    )]
    [IsoId("_M2EVgTqqEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Processing Status 3 Choice")]
    public abstract record CorporateActionEventProcessingStatus3Choice_ { }
}
