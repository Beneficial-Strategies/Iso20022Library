// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type112Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType112Choice.Code))]
    [KnownType(typeof(CorporateActionEventType112Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType112Choice.Code),nameof(CorporateActionEventType112Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType112Choice.Proprietary),nameof(CorporateActionEventType112Choice.Proprietary))]
    [IsoId("_-xC2pY-vEe-8QaP9hiQjxQ")]
    [DisplayName("Corporate Action Event Type112Choice")]
    public abstract partial record CorporateActionEventType112Choice_
    {
    }
}
