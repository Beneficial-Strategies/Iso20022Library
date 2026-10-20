// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information182.
/// </summary>
[IsoId("_-pmKsY-vEe-8QaP9hiQjxQ")]
[DisplayName("Corporate Action General Information182")]
public partial record CorporateActionGeneralInformation182
{
    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public required Max35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    public Max35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Class Action Number.
    /// </summary>
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    public Max35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType112Choice_ EventType { get; init; }
}
