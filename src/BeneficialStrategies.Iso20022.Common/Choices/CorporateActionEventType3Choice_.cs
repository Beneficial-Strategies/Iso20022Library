// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType3Choice.Code))]
    [KnownType(typeof(CorporateActionEventType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType3Choice.Code),
        nameof(CorporateActionEventType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType3Choice.Proprietary),
        nameof(CorporateActionEventType3Choice.Proprietary)
    )]
    [IsoId("_Q4g6Ytp-Ed-ak6NoX_4Aeg_489319317")]
    [DisplayName("Corporate Action Event Type 3 Choice")]
    public abstract record CorporateActionEventType3Choice_ { }
}
