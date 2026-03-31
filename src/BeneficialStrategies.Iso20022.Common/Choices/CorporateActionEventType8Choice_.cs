// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType8Choice.Code))]
    [KnownType(typeof(CorporateActionEventType8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType8Choice.Code),
        nameof(CorporateActionEventType8Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType8Choice.Proprietary),
        nameof(CorporateActionEventType8Choice.Proprietary)
    )]
    [IsoId("_JPlZG_mREeC_eLZALo-S0A")]
    [DisplayName("Corporate Action Event Type 8 Choice")]
    public abstract record CorporateActionEventType8Choice_ { }
}
