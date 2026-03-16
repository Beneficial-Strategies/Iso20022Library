// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType52Choice.Code))]
    [KnownType(typeof(CorporateActionEventType52Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType52Choice.Code),
        nameof(CorporateActionEventType52Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType52Choice.Proprietary),
        nameof(CorporateActionEventType52Choice.Proprietary)
    )]
    [IsoId("_I4S0lYr8EeaNFeVGetd6Xw")]
    [DisplayName("Corporate Action Event Type 52 Choice")]
    public abstract record CorporateActionEventType52Choice_ { }
}
