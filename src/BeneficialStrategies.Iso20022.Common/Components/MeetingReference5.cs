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
[IsoId("_Tk62R9p-Ed-ak6NoX_4Aeg_-8393617")]
[DisplayName("Meeting Reference")]
public partial record MeetingReference5
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_Tk62SNp-Ed-ak6NoX_4Aeg_-8393586")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_Tk62Sdp-Ed-ak6NoX_4Aeg_-8393525")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TlEAMNp-Ed-ak6NoX_4Aeg_-8393495")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeetingDateAndTime { get; init; } 
    
    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_TlEAMdp-Ed-ak6NoX_4Aeg_-8393433")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MeetingType2Code? Type { get; init; } 
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlEAMtp-Ed-ak6NoX_4Aeg_-8393154")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Choice_? Classification { get; init; } 
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_TlEAM9p-Ed-ak6NoX_4Aeg_-7473068")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = [];
    
    
    #nullable disable
    
}
