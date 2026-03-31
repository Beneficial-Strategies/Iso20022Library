// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information178.
/// </summary>
[IsoId("_rruOEYCeEe-3UrLQHGsjgQ")]
[DisplayName("Corporate Action General Information178")]
public record CorporateActionGeneralInformation178
{
    /// <summary>
    /// Class Action Number.
    /// </summary>
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    public IsoMax35Text? ClassActionNumber { get; init; }

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
    public CorporateActionEventProcessingType2Choice_? EventProcessingType { get; init; }

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType108Choice_ EventType { get; init; }

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
    public required FinancialInstrumentAttributes128 UnderlyingSecurity { get; init; }
}
