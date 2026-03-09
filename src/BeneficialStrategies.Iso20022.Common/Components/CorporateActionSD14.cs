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
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_-x-6wZ2FEeW-bsa36JFb9A")]
[DisplayName("Corporate Action SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSD14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSD14( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("__LIak52FEeW-bsa36JFb9A")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC&apos;s nominee name.
    /// </summary>
    [IsoId("__LIalZ2FEeW-bsa36JFb9A")]
    [DisplayName("Notice Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtceTp")]
    #endif
    [IsoXmlTag("NtceTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NoticeType1Code? NoticeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoticeType1Code? NoticeType { get; init; } 
    #else
    public NoticeType1Code? NoticeType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [IsoId("__LIanZ2FEeW-bsa36JFb9A")]
    [DisplayName("Event Cash Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCshVal")]
    #endif
    [IsoXmlTag("EvtCshVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; set; } 
    #endif
    
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [IsoId("__LIaq52FEeW-bsa36JFb9A")]
    [DisplayName("Number Of Shares To Be Issued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfShrsToBeIssd")]
    #endif
    [IsoXmlTag("NbOfShrsToBeIssd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfSharesToBeIssued { get; init; } 
    #else
    public System.UInt64? NumberOfSharesToBeIssued { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of shares that are part of the offer for example subscription offer.
    /// </summary>
    [IsoId("__LIas52FEeW-bsa36JFb9A")]
    [DisplayName("Total Number Of Shares Offered")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfShrsOfferd")]
    #endif
    [IsoXmlTag("TtlNbOfShrsOfferd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfSharesOffered { get; init; } 
    #else
    public System.UInt64? TotalNumberOfSharesOffered { get; set; } 
    #endif
    
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [IsoId("__LIau52FEeW-bsa36JFb9A")]
    [DisplayName("Cut Off Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CutOffDays")]
    #endif
    [IsoXmlTag("CutOffDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? CutOffDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CutOffDays { get; init; } 
    #else
    public System.UInt64? CutOffDays { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). It defines how time sensitive instruction and withdrawal process is. Offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for manual agent require hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [IsoId("__LIaw52FEeW-bsa36JFb9A")]
    [DisplayName("DTC Automated Offer Program")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCAutomtdOfferPrgm")]
    #endif
    [IsoXmlTag("DTCAutomtdOfferPrgm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    #else
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("__LIay52FEeW-bsa36JFb9A")]
    [DisplayName("DTC Recycle Cut Off Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCRcyclCutOffInd")]
    #endif
    [IsoXmlTag("DTCRcyclCutOffInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    #else
    public CutOff1Code? DTCRecycleCutOffIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Denotes whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [IsoId("__LIa052FEeW-bsa36JFb9A")]
    [DisplayName("Long Short Payment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngShrtPmtInd")]
    #endif
    [IsoXmlTag("LngShrtPmtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    #else
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [IsoId("__LIa252FEeW-bsa36JFb9A")]
    [DisplayName("Oversubscription Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptTp")]
    #endif
    [IsoXmlTag("OvrsbcptTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    #else
    public OversubscriptionType1Code? OversubscriptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    [IsoId("__LIa452FEeW-bsa36JFb9A")]
    [DisplayName("Conditional Payment Applicable Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlPmtAplblFlg")]
    #endif
    [IsoXmlTag("CondlPmtAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConditionalPaymentApplicableFlag { get; init; } 
    #else
    public System.String? ConditionalPaymentApplicableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("__LIa652FEeW-bsa36JFb9A")]
    [DisplayName("Solicitation Dealer Fee Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnDealrFeeFlg")]
    #endif
    [IsoXmlTag("SlctnDealrFeeFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SolicitationDealerFeeFlag { get; init; } 
    #else
    public System.String? SolicitationDealerFeeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether positions held in Custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("__LIa852FEeW-bsa36JFb9A")]
    [DisplayName("DTC Custody Eligible Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCCtdyElgblFlg")]
    #endif
    [IsoXmlTag("DTCCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCCustodyEligibleFlag { get; init; } 
    #else
    public System.String? DTCCustodyEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is eligible for Custody Reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("__LIa-52FEeW-bsa36JFb9A")]
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCReorgCtdyElgblFlg")]
    #endif
    [IsoXmlTag("DTCReorgCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCReorganisationCustodyEligibleFlag { get; init; } 
    #else
    public System.String? DTCReorganisationCustodyEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is eligible for Reorganisation Deposit Service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("__LIbA52FEeW-bsa36JFb9A")]
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCReorgDpstElgblFlg")]
    #endif
    [IsoXmlTag("DTCReorgDpstElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCReorganisationDepositEligibleFlag { get; init; } 
    #else
    public System.String? DTCReorganisationDepositEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    [IsoId("__LIbC52FEeW-bsa36JFb9A")]
    [DisplayName("Surrender Shares To Agent Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrrndrShrsToAgtFlg")]
    #endif
    [IsoXmlTag("SrrndrShrsToAgtFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SurrenderSharesToAgentFlag { get; init; } 
    #else
    public System.String? SurrenderSharesToAgentFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    [IsoId("__LIbE52FEeW-bsa36JFb9A")]
    [DisplayName("Step Up Privilege Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepUpPrvlgFlg")]
    #endif
    [IsoXmlTag("StepUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StepUpPrivilegeFlag { get; init; } 
    #else
    public System.String? StepUpPrivilegeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    [IsoId("__LIbG52FEeW-bsa36JFb9A")]
    [DisplayName("Rights Oversubscription Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsOvrsbcptFlg")]
    #endif
    [IsoXmlTag("RghtsOvrsbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsOversubscriptionFlag { get; init; } 
    #else
    public System.String? RightsOversubscriptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the shareholder will be able to round up his/her subscription in the event his/her rights are less than the requirement.
    /// </summary>
    [IsoId("__LIbI52FEeW-bsa36JFb9A")]
    [DisplayName("Rights Round Up Privilege Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsRndUpPrvlgFlg")]
    #endif
    [IsoXmlTag("RghtsRndUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsRoundUpPrivilegeFlag { get; init; } 
    #else
    public System.String? RightsRoundUpPrivilegeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    [IsoId("__LIbK52FEeW-bsa36JFb9A")]
    [DisplayName("Rights Transferable Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsTrfblFlg")]
    #endif
    [IsoXmlTag("RghtsTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsTransferableFlag { get; init; } 
    #else
    public System.String? RightsTransferableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("__LIbM52FEeW-bsa36JFb9A")]
    [DisplayName("Certificate Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertDtls")]
    #endif
    [IsoXmlTag("CertDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD15? CertificateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD15? CertificateDetails { get; init; } 
    #else
    public CorporateActionSD15? CertificateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Country of Issue used to determine whether the electable option requires Tax Exempt or Wire information when sending EDS elections via the CAIN message type.
    /// </summary>
    [IsoId("__LIbO52FEeW-bsa36JFb9A")]
    [DisplayName("EDS Messaging Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EDSMsggCtryCd")]
    #endif
    [IsoXmlTag("EDSMsggCtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? EDSMessagingCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? EDSMessagingCountryCode { get; init; } 
    #else
    public string? EDSMessagingCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("__LIbPZ2FEeW-bsa36JFb9A")]
    [DisplayName("RDP Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RDPRefNb")]
    #endif
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDPReferenceNumber { get; init; } 
    #else
    public System.String? RDPReferenceNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
