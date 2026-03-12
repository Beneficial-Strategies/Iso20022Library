// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType87Choice.Code))]
    [KnownType(typeof(CorporateActionEventType87Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType87Choice.Code),nameof(CorporateActionEventType87Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType87Choice.Proprietary),nameof(CorporateActionEventType87Choice.Proprietary))]
    [IsoId("_N8mDIeXnEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action Event Type 87 Choice")]
    public abstract partial record CorporateActionEventType87Choice_
    {
    }
}
