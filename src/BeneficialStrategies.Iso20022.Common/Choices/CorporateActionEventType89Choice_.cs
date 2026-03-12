// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType89Choice.Code))]
    [KnownType(typeof(CorporateActionEventType89Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType89Choice.Code),nameof(CorporateActionEventType89Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType89Choice.Proprietary),nameof(CorporateActionEventType89Choice.Proprietary))]
    [IsoId("_A0Qp7wVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 89 Choice")]
    public abstract partial record CorporateActionEventType89Choice_
    {
    }
}
