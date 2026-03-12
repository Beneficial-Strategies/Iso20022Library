// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType73Choice.Code))]
    [KnownType(typeof(CorporateActionEventType73Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType73Choice.Code),nameof(CorporateActionEventType73Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType73Choice.Proprietary),nameof(CorporateActionEventType73Choice.Proprietary))]
    [IsoId("_w71kkaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Corporate Action Event Type 73 Choice")]
    public abstract partial record CorporateActionEventType73Choice_
    {
    }
}
