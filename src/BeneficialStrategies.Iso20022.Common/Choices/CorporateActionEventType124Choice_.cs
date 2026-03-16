// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type124Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType124Choice.Code))]
    [KnownType(typeof(CorporateActionEventType124Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType124Choice.Code),nameof(CorporateActionEventType124Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType124Choice.Proprietary),nameof(CorporateActionEventType124Choice.Proprietary))]
    [IsoId("_nLXUuZt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type124Choice")]
    public abstract partial record CorporateActionEventType124Choice_
    {
    }
}
