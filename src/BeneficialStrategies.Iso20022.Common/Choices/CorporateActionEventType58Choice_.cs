// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType58Choice.Code))]
    [KnownType(typeof(CorporateActionEventType58Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType58Choice.Code),nameof(CorporateActionEventType58Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType58Choice.Proprietary),nameof(CorporateActionEventType58Choice.Proprietary))]
    [IsoId("_FSS1U5wsEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 58 Choice")]
    public abstract partial record CorporateActionEventType58Choice_
    {
    }
}
