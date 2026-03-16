// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information194.
/// </summary>
[IsoId("_nLXUW5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action General Information194")]
public partial record CorporateActionGeneralInformation194
{
    #nullable enable

    /// <summary>
    /// Class Action Number.
    /// </summary>
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 

    /// <summary>
    /// Event Processing Type.
    /// </summary>
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; } 

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType124Choice_ EventType { get; init; } 

    /// <summary>
    /// Mandatory Voluntary Event Type.
    /// </summary>
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 

    /// <summary>
    /// Official Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 

    /// <summary>
    /// Underlying Security.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentAttributes136 UnderlyingSecurity { get; init; } 

    
    #nullable disable
    
}
