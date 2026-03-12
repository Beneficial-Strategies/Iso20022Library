// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to cater for specific corporate action dates.
/// </summary>
[IsoId("_cmPZkCf2EeGwDKgZV-rDtQ")]
[DisplayName("Corporate Action Date 21 SD")]
public partial record CorporateActionDate21SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_aDPUUFPHEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Date and time of notification via web service as reference information.
    /// 通知日時 Notification date and time.
    /// </summary>
    [IsoId("_CPFqMCf3EeGwDKgZV-rDtQ")]
    [DisplayName("Web Service Notification Date")]
    [IsoXmlTag("WebSvcNtfctnDt")]
    public DateFormat22Choice_? WebServiceNotificationDate { get; init; } 
    
    /// <summary>
    /// Date and time of previous notification via web service as a reference information (in case of replacement). 
    /// 訂正（削除）前通知日時.
    /// </summary>
    [IsoId("_8vkRACf3EeGwDKgZV-rDtQ")]
    [DisplayName("Previous Web Service Notification Date")]
    [IsoXmlTag("PrvsWebSvcNtfctnDt")]
    public DateFormat22Choice_? PreviousWebServiceNotificationDate { get; init; } 
    
    /// <summary>
    /// Actual record date - the previous business day of the record date if the record date falls to Saturday, Sunday or national holiday.
    /// 権利確定日.
    /// </summary>
    [IsoId("_FS6LECf4EeGwDKgZV-rDtQ")]
    [DisplayName("Actual Record Date")]
    [IsoXmlTag("ActlRcrdDt")]
    public DateFormat22Choice_? ActualRecordDate { get; init; } 
    
    /// <summary>
    /// Date of the board meeting.
    /// 取締役会決議日.
    /// </summary>
    [IsoId("_uTcX0DDNEeGmr_ZdHrulRQ")]
    [DisplayName("Board Meeting Date")]
    [IsoXmlTag("BrdMtgDt")]
    public DateFormat22Choice_? BoardMeetingDate { get; init; } 
    
    /// <summary>
    /// Date on which the new company will be registered.
    /// 新設会社登記日.
    /// </summary>
    [IsoId("_40FjsFCYEeGr9IkH55jg4g")]
    [DisplayName("Corporate Registration Date")]
    [IsoXmlTag("CorpRegnDt")]
    public DateFormat22Choice_? CorporateRegistrationDate { get; init; } 
    
    /// <summary>
    /// Earliest planned date on which the issue price will be set.
    /// 発行価格決定予定日（最短）.
    /// </summary>
    [IsoId("_HFAPIFCaEeGr9IkH55jg4g")]
    [DisplayName("Earliest Planned Date Of Issue Price")]
    [IsoXmlTag("EarlstPlandDtOfIssePric")]
    public DateFormat22Choice_? EarliestPlannedDateOfIssuePrice { get; init; } 
    
    /// <summary>
    /// Latest planned date on which the issue price will be set.
    /// 発行価格決定予定日（最長）.
    /// </summary>
    [IsoId("_X9kHsFCaEeGr9IkH55jg4g")]
    [DisplayName("Latest Planned Date Of Issue Price")]
    [IsoXmlTag("LatstPlandDtOfIssePric")]
    public DateFormat22Choice_? LatestPlannedDateOfIssuePrice { get; init; } 
    
    /// <summary>
    /// Date on which the issue price will be set.
    /// 発行価格決定日.
    /// </summary>
    [IsoId("_lda_EFCaEeGr9IkH55jg4g")]
    [DisplayName("Date Of Issue Price")]
    [IsoXmlTag("DtOfIssePric")]
    public DateFormat22Choice_? DateOfIssuePrice { get; init; } 
    
    /// <summary>
    /// Earliest planned date on which the cash payment (for the subscription cost) will be made.
    /// 払込期日予定日（最短）.
    /// </summary>
    [IsoId("_8GoAkFCaEeGr9IkH55jg4g")]
    [DisplayName("Earliest Planned Subscription Cost Payment Date")]
    [IsoXmlTag("EarlstPlandSbcptCostPmtDt")]
    public DateFormat22Choice_? EarliestPlannedSubscriptionCostPaymentDate { get; init; } 
    
    /// <summary>
    /// Latest planned date on which the cash payment (for the subscription cost) will be made.
    /// 払込期日予定日（最長）.
    /// </summary>
    [IsoId("_NwmH8FCbEeGr9IkH55jg4g")]
    [DisplayName("Latest Planned Subscription Cost Payment Date")]
    [IsoXmlTag("LatstPlandSbcptCostPmtDt")]
    public DateFormat22Choice_? LatestPlannedSubscriptionCostPaymentDate { get; init; } 
    
    /// <summary>
    /// Listing date of the new shares announced by Stock Exchange.
    /// 変更上場日.
    /// </summary>
    [IsoId("_NajsoFFCEeGr9IkH55jg4g")]
    [DisplayName("Subsequent Listing Date")]
    [IsoXmlTag("SbsqntListgDt")]
    public DateFormat22Choice_? SubsequentListingDate { get; init; } 
    
    /// <summary>
    /// Date at which the new share unit quantity becomes effective.
    /// </summary>
    [IsoId("_8bDpQGEqEeKBtLl-jeT19Q")]
    [DisplayName("New Share Unit Quantity Effective Date")]
    [IsoXmlTag("NewShrUnitQtyFctvDt")]
    public DateFormat22Choice_? NewShareUnitQuantityEffectiveDate { get; init; } 
    
    
    #nullable disable
    
}
