// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type118Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType118Choice.Code))]
    [KnownType(typeof(CorporateActionEventType118Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType118Choice.Code),nameof(CorporateActionEventType118Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType118Choice.Proprietary),nameof(CorporateActionEventType118Choice.Proprietary))]
    [IsoId("_kLozUpt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type118Choice")]
    public abstract partial record CorporateActionEventType118Choice_
    {
    }
}
