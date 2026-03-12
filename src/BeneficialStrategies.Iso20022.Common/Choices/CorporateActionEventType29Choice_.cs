// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType29Choice.Code))]
    [KnownType(typeof(CorporateActionEventType29Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType29Choice.Code),nameof(CorporateActionEventType29Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType29Choice.Proprietary),nameof(CorporateActionEventType29Choice.Proprietary))]
    [IsoId("_Jlw70Tp9EeWVrPy0StzzSg")]
    [DisplayName("Corporate Action Event Type 29 Choice")]
    public abstract partial record CorporateActionEventType29Choice_
    {
    }
}
