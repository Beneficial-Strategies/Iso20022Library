// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type121Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType121Choice.Code))]
    [KnownType(typeof(CorporateActionEventType121Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType121Choice.Code),nameof(CorporateActionEventType121Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType121Choice.Proprietary),nameof(CorporateActionEventType121Choice.Proprietary))]
    [IsoId("_lxWMS5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type121Choice")]
    public abstract partial record CorporateActionEventType121Choice_
    {
    }
}
