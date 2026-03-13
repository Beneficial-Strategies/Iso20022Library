// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a meeting.
/// </summary>
[IsoId("_eHSlsa7NEemG7MmivSuE5g")]
[DisplayName("Meeting Reference")]
public partial record MeetingReference8
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification.
    /// </summary>
    [IsoId("_edv9467NEemG7MmivSuE5g")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_edv95a7NEemG7MmivSuE5g")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_edv9567NEemG7MmivSuE5g")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime MeetingDateAndTime { get; init; } 
    
    /// <summary>
    /// Type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_edv96a7NEemG7MmivSuE5g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; } 
    
    /// <summary>
    /// Classification type of the meeting.
    /// </summary>
    [IsoId("_edv9667NEemG7MmivSuE5g")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_edv97a7NEemG7MmivSuE5g")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = [];
    
    /// <summary>
    /// Specifies the institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_ct82kcAYEembi_x1QDJfxw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; } 
    
    
    #nullable disable
    
}
