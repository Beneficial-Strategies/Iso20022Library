// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType79Choice.Code))]
    [KnownType(typeof(CorporateActionEventType79Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType79Choice.Code),
        nameof(CorporateActionEventType79Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType79Choice.Proprietary),
        nameof(CorporateActionEventType79Choice.Proprietary)
    )]
    [IsoId("_OLYZ1c3xEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Type 79 Choice")]
    public abstract record CorporateActionEventType79Choice_ { }
}
