// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType50Choice.Code))]
    [KnownType(typeof(CorporateActionEventType50Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType50Choice.Code),
        nameof(CorporateActionEventType50Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType50Choice.Proprietary),
        nameof(CorporateActionEventType50Choice.Proprietary)
    )]
    [IsoId("_VygDw5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Corporate Action Event Type 50 Choice")]
    public abstract record CorporateActionEventType50Choice_ { }
}
