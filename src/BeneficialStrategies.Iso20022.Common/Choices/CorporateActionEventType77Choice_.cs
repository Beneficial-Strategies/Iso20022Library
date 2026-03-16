// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType77Choice.Code))]
    [KnownType(typeof(CorporateActionEventType77Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType77Choice.Code),
        nameof(CorporateActionEventType77Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType77Choice.Proprietary),
        nameof(CorporateActionEventType77Choice.Proprietary)
    )]
    [IsoId("_ncxYd83hEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Type 77 Choice")]
    public abstract record CorporateActionEventType77Choice_ { }
}
