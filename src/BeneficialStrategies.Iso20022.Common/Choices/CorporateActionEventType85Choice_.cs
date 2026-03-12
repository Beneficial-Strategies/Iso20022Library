// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType85Choice.Code))]
    [KnownType(typeof(CorporateActionEventType85Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType85Choice.Code),nameof(CorporateActionEventType85Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType85Choice.Proprietary),nameof(CorporateActionEventType85Choice.Proprietary))]
    [IsoId("_1yFm5eXmEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action Event Type 85 Choice")]
    public abstract partial record CorporateActionEventType85Choice_
    {
    }
}
