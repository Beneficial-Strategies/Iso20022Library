// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Processing Type4Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingType4Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType4Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType4Choice.Code),nameof(CorporateActionEventProcessingType4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType4Choice.Proprietary),nameof(CorporateActionEventProcessingType4Choice.Proprietary))]
    [IsoId("_Q9h6kYboEe--EK81FcmyRA")]
    [DisplayName("Corporate Action Event Processing Type4Choice")]
    public abstract partial record CorporateActionEventProcessingType4Choice_
    {
    }
}
