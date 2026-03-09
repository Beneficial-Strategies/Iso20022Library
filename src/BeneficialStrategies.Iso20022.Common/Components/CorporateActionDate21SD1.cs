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
/// Extension to cater for specific corporate action dates.
/// </summary>
[IsoId("_cmPZkCf2EeGwDKgZV-rDtQ")]
[DisplayName("Corporate Action Date 21 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate21SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_aDPUUFPHEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of notification via web service as reference information.
    /// 通知日時 Notification date and time.
    /// </summary>
    [IsoId("_CPFqMCf3EeGwDKgZV-rDtQ")]
    [DisplayName("Web Service Notification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WebSvcNtfctnDt")]
    #endif
    [IsoXmlTag("WebSvcNtfctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? WebServiceNotificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? WebServiceNotificationDate { get; init; } 
    #else
    public DateFormat22Choice_? WebServiceNotificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of previous notification via web service as a reference information (in case of replacement). 
    /// 訂正（削除）前通知日時.
    /// </summary>
    [IsoId("_8vkRACf3EeGwDKgZV-rDtQ")]
    [DisplayName("Previous Web Service Notification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsWebSvcNtfctnDt")]
    #endif
    [IsoXmlTag("PrvsWebSvcNtfctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? PreviousWebServiceNotificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? PreviousWebServiceNotificationDate { get; init; } 
    #else
    public DateFormat22Choice_? PreviousWebServiceNotificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual record date - the previous business day of the record date if the record date falls to Saturday, Sunday or national holiday.
    /// 権利確定日.
    /// </summary>
    [IsoId("_FS6LECf4EeGwDKgZV-rDtQ")]
    [DisplayName("Actual Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlRcrdDt")]
    #endif
    [IsoXmlTag("ActlRcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? ActualRecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? ActualRecordDate { get; init; } 
    #else
    public DateFormat22Choice_? ActualRecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the board meeting.
    /// 取締役会決議日.
    /// </summary>
    [IsoId("_uTcX0DDNEeGmr_ZdHrulRQ")]
    [DisplayName("Board Meeting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrdMtgDt")]
    #endif
    [IsoXmlTag("BrdMtgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? BoardMeetingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? BoardMeetingDate { get; init; } 
    #else
    public DateFormat22Choice_? BoardMeetingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the new company will be registered.
    /// 新設会社登記日.
    /// </summary>
    [IsoId("_40FjsFCYEeGr9IkH55jg4g")]
    [DisplayName("Corporate Registration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpRegnDt")]
    #endif
    [IsoXmlTag("CorpRegnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? CorporateRegistrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? CorporateRegistrationDate { get; init; } 
    #else
    public DateFormat22Choice_? CorporateRegistrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest planned date on which the issue price will be set.
    /// 発行価格決定予定日（最短）.
    /// </summary>
    [IsoId("_HFAPIFCaEeGr9IkH55jg4g")]
    [DisplayName("Earliest Planned Date Of Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPlandDtOfIssePric")]
    #endif
    [IsoXmlTag("EarlstPlandDtOfIssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? EarliestPlannedDateOfIssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? EarliestPlannedDateOfIssuePrice { get; init; } 
    #else
    public DateFormat22Choice_? EarliestPlannedDateOfIssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Latest planned date on which the issue price will be set.
    /// 発行価格決定予定日（最長）.
    /// </summary>
    [IsoId("_X9kHsFCaEeGr9IkH55jg4g")]
    [DisplayName("Latest Planned Date Of Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstPlandDtOfIssePric")]
    #endif
    [IsoXmlTag("LatstPlandDtOfIssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? LatestPlannedDateOfIssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? LatestPlannedDateOfIssuePrice { get; init; } 
    #else
    public DateFormat22Choice_? LatestPlannedDateOfIssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the issue price will be set.
    /// 発行価格決定日.
    /// </summary>
    [IsoId("_lda_EFCaEeGr9IkH55jg4g")]
    [DisplayName("Date Of Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfIssePric")]
    #endif
    [IsoXmlTag("DtOfIssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? DateOfIssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? DateOfIssuePrice { get; init; } 
    #else
    public DateFormat22Choice_? DateOfIssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest planned date on which the cash payment (for the subscription cost) will be made.
    /// 払込期日予定日（最短）.
    /// </summary>
    [IsoId("_8GoAkFCaEeGr9IkH55jg4g")]
    [DisplayName("Earliest Planned Subscription Cost Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPlandSbcptCostPmtDt")]
    #endif
    [IsoXmlTag("EarlstPlandSbcptCostPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? EarliestPlannedSubscriptionCostPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? EarliestPlannedSubscriptionCostPaymentDate { get; init; } 
    #else
    public DateFormat22Choice_? EarliestPlannedSubscriptionCostPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Latest planned date on which the cash payment (for the subscription cost) will be made.
    /// 払込期日予定日（最長）.
    /// </summary>
    [IsoId("_NwmH8FCbEeGr9IkH55jg4g")]
    [DisplayName("Latest Planned Subscription Cost Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstPlandSbcptCostPmtDt")]
    #endif
    [IsoXmlTag("LatstPlandSbcptCostPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? LatestPlannedSubscriptionCostPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? LatestPlannedSubscriptionCostPaymentDate { get; init; } 
    #else
    public DateFormat22Choice_? LatestPlannedSubscriptionCostPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Listing date of the new shares announced by Stock Exchange.
    /// 変更上場日.
    /// </summary>
    [IsoId("_NajsoFFCEeGr9IkH55jg4g")]
    [DisplayName("Subsequent Listing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntListgDt")]
    #endif
    [IsoXmlTag("SbsqntListgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? SubsequentListingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? SubsequentListingDate { get; init; } 
    #else
    public DateFormat22Choice_? SubsequentListingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the new share unit quantity becomes effective.
    /// </summary>
    [IsoId("_8bDpQGEqEeKBtLl-jeT19Q")]
    [DisplayName("New Share Unit Quantity Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewShrUnitQtyFctvDt")]
    #endif
    [IsoXmlTag("NewShrUnitQtyFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat22Choice_? NewShareUnitQuantityEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat22Choice_? NewShareUnitQuantityEffectiveDate { get; init; } 
    #else
    public DateFormat22Choice_? NewShareUnitQuantityEffectiveDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
