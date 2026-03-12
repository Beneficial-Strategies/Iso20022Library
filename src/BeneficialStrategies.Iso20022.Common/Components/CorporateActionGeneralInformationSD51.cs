// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
[IsoId("_lLXoQTDrEey2N-DB7H7A5A")]
[DisplayName("Corporate Action General Information SD")]
public partial record CorporateActionGeneralInformationSD51
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_lg064TDrEey2N-DB7H7A5A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_lg064zDrEey2N-DB7H7A5A")]
    [DisplayName("Event Group")]
    [IsoXmlTag("EvtGrp")]
    public EventGroup2Code? EventGroup { get; init; } 
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_lg066zDrEey2N-DB7H7A5A")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public ExtendedEventType6Code? EventType { get; init; } 
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_lg068zDrEey2N-DB7H7A5A")]
    [DisplayName("Sub Event Type")]
    [IsoXmlTag("SubEvtTp")]
    public DTCCSubEventType10Code? SubEventType { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_lg06-zDrEey2N-DB7H7A5A")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification20 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_lg07CTDrEey2N-DB7H7A5A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    [IsoId("_lg07FzDrEey2N-DB7H7A5A")]
    [DisplayName("Unallocated Details")]
    [IsoXmlTag("UallctdDtls")]
    public CorporateActionUnallocatedDetailsSD7? UnallocatedDetails { get; init; } 
    
    
    #nullable disable
    
}
