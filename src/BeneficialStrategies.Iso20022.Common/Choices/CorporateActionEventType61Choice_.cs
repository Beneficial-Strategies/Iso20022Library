// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType61Choice.Code))]
    [KnownType(typeof(CorporateActionEventType61Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType61Choice.Code),nameof(CorporateActionEventType61Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType61Choice.Proprietary),nameof(CorporateActionEventType61Choice.Proprietary))]
    [IsoId("_x52mPJwsEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 61 Choice")]
    public abstract partial record CorporateActionEventType61Choice_
    {
    }
}
