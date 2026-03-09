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
/// Provides information about the notification advice.
/// </summary>
[IsoId("_UKUpZtp-Ed-ak6NoX_4Aeg_1910542710")]
[DisplayName("Corporate Action Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotification1( ProcessingStatus1FormatChoice_ reqProcessingStatus )
    {
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_UKUpZ9p-Ed-ak6NoX_4Aeg_1619065277")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? AnnouncementDate { get; init; } 
    #else
    public DateFormat4Choice_? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, eg, exchange ratio announcement date.
    /// </summary>
    [IsoId("_UKUpaNp-Ed-ak6NoX_4Aeg_1630150555")]
    [DisplayName("Further Detailed Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrthrDtldAnncmntDt")]
    #endif
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #else
    public DateFormat4Choice_? FurtherDetailedAnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, eg, publication by a governmental administration.
    /// </summary>
    [IsoId("_UKUpadp-Ed-ak6NoX_4Aeg_-1290955122")]
    [DisplayName("Official Announcement Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclAnncmntPblctnDt")]
    #endif
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #else
    public DateFormat4Choice_? OfficialAnnouncementPublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_UKUpatp-Ed-ak6NoX_4Aeg_1527353717")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingStatus1FormatChoice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingStatus1FormatChoice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus1FormatChoice_ ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus1FormatChoice_ ProcessingStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
