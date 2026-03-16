// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type105Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType105Choice.ExtendedCorporateEventType))]
    [KnownType(typeof(CorporateActionEventType105Choice.PlainCorporateEventType))]
    [JsonDerivedType(typeof(CorporateActionEventType105Choice.ExtendedCorporateEventType),nameof(CorporateActionEventType105Choice.ExtendedCorporateEventType))]
    [JsonDerivedType(typeof(CorporateActionEventType105Choice.PlainCorporateEventType),nameof(CorporateActionEventType105Choice.PlainCorporateEventType))]
    [IsoId("_wD5uwEm1Ee-NocYul3BKXQ")]
    [DisplayName("Corporate Action Event Type105Choice")]
    public abstract partial record CorporateActionEventType105Choice_
    {
    }
}
