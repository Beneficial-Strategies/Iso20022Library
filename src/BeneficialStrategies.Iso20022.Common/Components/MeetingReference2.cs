// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements which allow to identify a meeting.
/// </summary>
[IsoId("_TlqdItp-Ed-ak6NoX_4Aeg_-1779095008")]
[DisplayName("Meeting Reference")]
public partial record MeetingReference2
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TlqdI9p-Ed-ak6NoX_4Aeg_-1779094991")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TlqdJNp-Ed-ak6NoX_4Aeg_-1779094973")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TlqdJdp-Ed-ak6NoX_4Aeg_-1779094948")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeetingDateAndTime { get; init; } 
    
    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_TlqdJtp-Ed-ak6NoX_4Aeg_-1779094931")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MeetingType2Code? Type { get; init; } 
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlqdJ9p-Ed-ak6NoX_4Aeg_-260826406")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Code? Classification { get; init; } 
    
    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    [IsoId("_TlqdKNp-Ed-ak6NoX_4Aeg_1116862835")]
    [DisplayName("Extended Classification")]
    [IsoXmlTag("XtndedClssfctn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedClassification { get; init; } 
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_TlqdKdp-Ed-ak6NoX_4Aeg_-1778174910")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = new ValueList<PostalAddress1>(){};
    
    
    #nullable disable
    
}
