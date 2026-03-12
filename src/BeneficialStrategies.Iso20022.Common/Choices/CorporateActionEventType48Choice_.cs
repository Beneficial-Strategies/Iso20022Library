// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType48Choice.Code))]
    [KnownType(typeof(CorporateActionEventType48Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType48Choice.Code),nameof(CorporateActionEventType48Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType48Choice.Proprietary),nameof(CorporateActionEventType48Choice.Proprietary))]
    [IsoId("_8VKXpZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type 48 Choice")]
    public abstract partial record CorporateActionEventType48Choice_
    {
    }
}
