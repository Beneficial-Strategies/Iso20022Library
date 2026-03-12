// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType90Choice.Code))]
    [KnownType(typeof(CorporateActionEventType90Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType90Choice.Code),nameof(CorporateActionEventType90Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType90Choice.Proprietary),nameof(CorporateActionEventType90Choice.Proprietary))]
    [IsoId("_Szi6FAVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 90 Choice")]
    public abstract partial record CorporateActionEventType90Choice_
    {
    }
}
