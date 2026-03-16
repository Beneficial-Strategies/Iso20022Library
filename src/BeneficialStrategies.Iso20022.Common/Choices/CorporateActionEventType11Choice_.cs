// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType11Choice.Code))]
    [KnownType(typeof(CorporateActionEventType11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType11Choice.Code),
        nameof(CorporateActionEventType11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType11Choice.Proprietary),
        nameof(CorporateActionEventType11Choice.Proprietary)
    )]
    [IsoId("_SdmZwQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Corporate Action Event Type 11 Choice")]
    public abstract record CorporateActionEventType11Choice_ { }
}
