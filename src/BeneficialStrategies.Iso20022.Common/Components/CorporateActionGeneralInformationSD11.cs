// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information details.
/// </summary>
[IsoId("_E2JfcUkzEeK8UrXTVVBVxw")]
[DisplayName("Corporate Action General Information SD")]
public partial record CorporateActionGeneralInformationSD11
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_FN1msUkzEeK8UrXTVVBVxw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_FN1mtUkzEeK8UrXTVVBVxw")]
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup1Code? EventGroup { get; init; } 
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_FN1mv0kzEeK8UrXTVVBVxw")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType1Code? EventType { get; init; } 
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_FN1myUkzEeK8UrXTVVBVxw")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType2Code? SubEventType { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the event with regard to how it is being supported by DTC (The Depository Trust Corporation) the custodian: whether the event is mandatory, voluntary, or mandatory with options and eligible for DTC processing. This classification is necessary for the event types that have additional DTC only options. For an example: a MAND event, where the issuer declared only one option may be eligible for special DTC options (services like Dividend Reinvestment, Foreign Currency Payment, etc) in this case it will be announced as MAND by the issuer and CHOS by DTC.
    /// </summary>
    [IsoId("_FN1m00kzEeK8UrXTVVBVxw")]
    [DisplayName("DTC Mandatory Voluntary Event Type")]
    [IsoXmlTag("DTCMndtryVlntryEvtTp")]
    public CorporateActionMandatoryVoluntary1Code? DTCMandatoryVoluntaryEventType { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the event as announced by the agent or issuer.
    /// </summary>
    [IsoId("_FN1m3UkzEeK8UrXTVVBVxw")]
    [DisplayName("Declared Mandatory Voluntary Event Type")]
    [IsoXmlTag("DclrdMndtryVlntryEvtTp")]
    public CorporateActionMandatoryVoluntary1Code? DeclaredMandatoryVoluntaryEventType { get; init; } 
    
    /// <summary>
    /// Indicates whether the event is eligible for EDS (Elective Dividend Services) ISO20022 messaging.
    /// </summary>
    [IsoId("_KdxPRUkzEeK8UrXTVVBVxw")]
    [DisplayName("EDS Messaging Eligibility Flag")]
    [IsoXmlTag("EDSMsggElgbltyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EDSMessagingEligibilityFlag { get; init; } 
    
    
    #nullable disable
    
}
