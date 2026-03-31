// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType76Choice.Code))]
    [KnownType(typeof(CorporateActionEventType76Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType76Choice.Code),
        nameof(CorporateActionEventType76Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType76Choice.Proprietary),
        nameof(CorporateActionEventType76Choice.Proprietary)
    )]
    [IsoId("_b3VHZZSeEeeh5JjedkaA_g")]
    [DisplayName("Corporate Action Event Type 76 Choice")]
    public abstract record CorporateActionEventType76Choice_ { }
}
