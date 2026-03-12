// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about event of a corporate action.
/// </summary>
[IsoId("_TV3tp9p-Ed-ak6NoX_4Aeg_945783241")]
[DisplayName("Event Information")]
public partial record EventInformation1
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TWA3kNp-Ed-ak6NoX_4Aeg_1407542734")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
    
    /// <summary>
    /// Provides the reference of the linked official corporate action event.
    /// </summary>
    [IsoId("_TWA3kdp-Ed-ak6NoX_4Aeg_1710459341")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_TWA3ktp-Ed-ak6NoX_4Aeg_1763101510")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType3Choice_ EventType { get; init; } 
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_TWA3k9p-Ed-ak6NoX_4Aeg_-1239931920")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; } 
    
    /// <summary>
    /// Provides information about the identification of the last notification.
    /// </summary>
    [IsoId("_TWA3lNp-Ed-ak6NoX_4Aeg_-1815481179")]
    [DisplayName("Last Notification Identification")]
    [IsoXmlTag("LastNtfctnId")]
    public NotificationIdentification1? LastNotificationIdentification { get; init; } 
    
    
    #nullable disable
    
}
