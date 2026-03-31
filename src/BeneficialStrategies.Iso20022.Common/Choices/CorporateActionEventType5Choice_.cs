// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType5Choice.Code))]
    [KnownType(typeof(CorporateActionEventType5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType5Choice.Code),
        nameof(CorporateActionEventType5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType5Choice.Proprietary),
        nameof(CorporateActionEventType5Choice.Proprietary)
    )]
    [IsoId("_5QPG4ffcEd-5M-tMFgHEdw")]
    [DisplayName("Corporate Action Event Type 5 Choice")]
    public abstract record CorporateActionEventType5Choice_ { }
}
