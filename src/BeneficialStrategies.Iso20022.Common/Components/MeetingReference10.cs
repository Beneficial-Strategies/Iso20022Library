// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a meeting.
/// </summary>
[IsoId("_UP25gfKxEeqRfth943bvEA")]
[DisplayName("Meeting Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingReference10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingReference10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingReference10( System.String reqMeetingIdentification,System.DateTime reqMeetingDateAndTime,MeetingType4Code reqType )
    {
        MeetingIdentification = reqMeetingIdentification;
        MeetingDateAndTime = reqMeetingDateAndTime;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification.
    /// </summary>
    [IsoId("_Uk1D8_KxEeqRfth943bvEA")]
    [DisplayName("Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgId")]
    #endif
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MeetingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MeetingIdentification { get; init; } 
    #else
    public System.String MeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_Uk1D9fKxEeqRfth943bvEA")]
    [DisplayName("Issuer Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrMtgId")]
    #endif
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerMeetingIdentification { get; init; } 
    #else
    public System.String? IssuerMeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_Uk1D9_KxEeqRfth943bvEA")]
    [DisplayName("Meeting Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgDtAndTm")]
    #endif
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime MeetingDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime MeetingDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime MeetingDateAndTime { get; init; } 
    #else
    public System.DateTime MeetingDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_Uk1D-fKxEeqRfth943bvEA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingType4Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingType4Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingType4Code Type { get; init; } 
    #else
    public MeetingType4Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the meeting.
    /// </summary>
    [IsoId("_Uk1D-_KxEeqRfth943bvEA")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    #else
    public MeetingTypeClassification2Choice_? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_Uk1D_fKxEeqRfth943bvEA")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_Uk1D__KxEeqRfth943bvEA")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification129Choice_? Issuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
