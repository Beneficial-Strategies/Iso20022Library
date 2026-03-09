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
/// Elements which allow to identify a meeting.
/// </summary>
[IsoId("_TlgsINp-Ed-ak6NoX_4Aeg_-1687570906")]
[DisplayName("Meeting Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingReference3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingReference3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingReference3( System.DateTime reqMeetingDateAndTime,MeetingType2Code reqType )
    {
        MeetingDateAndTime = reqMeetingDateAndTime;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TlgsIdp-Ed-ak6NoX_4Aeg_-1687570904")]
    [DisplayName("Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgId")]
    #endif
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MeetingIdentification { get; init; } 
    #else
    public System.String? MeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TlgsItp-Ed-ak6NoX_4Aeg_-1687570888")]
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
    [IsoId("_TlgsI9p-Ed-ak6NoX_4Aeg_-1687570871")]
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
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_TlgsJNp-Ed-ak6NoX_4Aeg_-1687570853")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingType2Code Type { get; init; } 
    #else
    public MeetingType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlgsJdp-Ed-ak6NoX_4Aeg_-1687570828")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingTypeClassification1Code? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingTypeClassification1Code? Classification { get; init; } 
    #else
    public MeetingTypeClassification1Code? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    [IsoId("_TlgsJtp-Ed-ak6NoX_4Aeg_1906473527")]
    [DisplayName("Extended Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedClssfctn")]
    #endif
    [IsoXmlTag("XtndedClssfctn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedClassification { get; init; } 
    #else
    public System.String? ExtendedClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_TlgsJ9p-Ed-ak6NoX_4Aeg_-1687570810")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = new ValueList<PostalAddress1>(){};
    
    
    #nullable disable
    
}
