// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType42Choice.Code))]
    [KnownType(typeof(CorporateActionEventType42Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType42Choice.Code),
        nameof(CorporateActionEventType42Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType42Choice.Proprietary),
        nameof(CorporateActionEventType42Choice.Proprietary)
    )]
    [IsoId("_cslQ45KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Type 42 Choice")]
    public abstract record CorporateActionEventType42Choice_ { }
}
