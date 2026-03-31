// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType16Choice.Code))]
    [KnownType(typeof(CorporateActionEventType16Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType16Choice.Code),
        nameof(CorporateActionEventType16Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType16Choice.Proprietary),
        nameof(CorporateActionEventType16Choice.Proprietary)
    )]
    [IsoId("_EdZyISM9EeKqJ_haxcymCw")]
    [DisplayName("Corporate Action Event Type 16 Choice")]
    public abstract record CorporateActionEventType16Choice_ { }
}
