// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType69Choice.Code))]
    [KnownType(typeof(CorporateActionEventType69Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType69Choice.Code),nameof(CorporateActionEventType69Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType69Choice.Proprietary),nameof(CorporateActionEventType69Choice.Proprietary))]
    [IsoId("_M_NGr5wxEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 69 Choice")]
    public abstract partial record CorporateActionEventType69Choice_
    {
    }
}
