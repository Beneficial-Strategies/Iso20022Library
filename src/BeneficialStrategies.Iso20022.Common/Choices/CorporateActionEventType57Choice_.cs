// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType57Choice.Code))]
    [KnownType(typeof(CorporateActionEventType57Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType57Choice.Code),
        nameof(CorporateActionEventType57Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType57Choice.Proprietary),
        nameof(CorporateActionEventType57Choice.Proprietary)
    )]
    [IsoId("_sb-57ZwqEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 57 Choice")]
    public abstract record CorporateActionEventType57Choice_ { }
}
