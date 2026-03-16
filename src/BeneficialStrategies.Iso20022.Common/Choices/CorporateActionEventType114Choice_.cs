// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type114Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType114Choice.Code))]
    [KnownType(typeof(CorporateActionEventType114Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType114Choice.Code),nameof(CorporateActionEventType114Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType114Choice.Proprietary),nameof(CorporateActionEventType114Choice.Proprietary))]
    [IsoId("_jWq5uZt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type114Choice")]
    public abstract partial record CorporateActionEventType114Choice_
    {
    }
}
