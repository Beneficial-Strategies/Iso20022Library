// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information175.
/// </summary>
[IsoId("_hmW9EYCdEe-3UrLQHGsjgQ")]
[DisplayName("Corporate Action General Information175")]
public record CorporateActionGeneralInformation175
{
    /// <summary>
    /// Agent Identification.
    /// </summary>
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    public required PartyIdentification129Choice_ AgentIdentification { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Event Processing Type.
    /// </summary>
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType4Choice_? EventProcessingType { get; init; }

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType107Choice_ EventType { get; init; }

    /// <summary>
    /// Mandatory Voluntary Event Type.
    /// </summary>
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Official Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Underlying Security.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentDescription5 UnderlyingSecurity { get; init; }
}
