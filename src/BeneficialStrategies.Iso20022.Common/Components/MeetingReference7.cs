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
[IsoId("_uG79UVuPEeSmO6RkXg92Lg")]
[DisplayName("Meeting Reference")]
public partial record MeetingReference7
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_ujNpo1uPEeSmO6RkXg92Lg")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_ujNppVuPEeSmO6RkXg92Lg")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_ujNpp1uPEeSmO6RkXg92Lg")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime MeetingDateAndTime { get; init; } 
    
    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_ujNpqVuPEeSmO6RkXg92Lg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType3Code Type { get; init; } 
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_ujNpq1uPEeSmO6RkXg92Lg")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Choice_? Classification { get; init; } 
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_ujNprVuPEeSmO6RkXg92Lg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = [];
    
    
    #nullable disable
    
}
