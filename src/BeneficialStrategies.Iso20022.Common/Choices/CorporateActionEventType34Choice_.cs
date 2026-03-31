// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType34Choice.Code))]
    [KnownType(typeof(CorporateActionEventType34Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType34Choice.Code),
        nameof(CorporateActionEventType34Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType34Choice.Proprietary),
        nameof(CorporateActionEventType34Choice.Proprietary)
    )]
    [IsoId("_iZJ_wUGKEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Event Type 34 Choice")]
    public abstract record CorporateActionEventType34Choice_ { }
}
