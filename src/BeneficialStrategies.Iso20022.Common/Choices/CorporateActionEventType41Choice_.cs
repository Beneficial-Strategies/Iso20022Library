// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType41Choice.Code))]
    [KnownType(typeof(CorporateActionEventType41Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType41Choice.Code),
        nameof(CorporateActionEventType41Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType41Choice.Proprietary),
        nameof(CorporateActionEventType41Choice.Proprietary)
    )]
    [IsoId("_cjsaU5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Type 41 Choice")]
    public abstract record CorporateActionEventType41Choice_ { }
}
