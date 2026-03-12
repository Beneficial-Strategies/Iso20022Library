// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType97Choice.Code))]
    [KnownType(typeof(CorporateActionEventType97Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType97Choice.Code),nameof(CorporateActionEventType97Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType97Choice.Proprietary),nameof(CorporateActionEventType97Choice.Proprietary))]
    [IsoId("_Ovm5XAVTEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 97 Choice")]
    public abstract partial record CorporateActionEventType97Choice_
    {
    }
}
