// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_Xv0Y8Q7vEeuZI5Sr_GAcuA")]
[DisplayName("Corporate Action SD")]
public partial record CorporateActionSD22
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_YEpZcw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC&apos;s nominee name.
    /// </summary>
    [IsoId("_YEpZdQ7vEeuZI5Sr_GAcuA")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public NoticeType1Code? NoticeType { get; init; } 
    
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [IsoId("_YEpZfQ7vEeuZI5Sr_GAcuA")]
    [DisplayName("Event Cash Value")]
    [IsoXmlTag("EvtCshVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [IsoId("_YEpZiw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Number Of Shares To Be Issued")]
    [IsoXmlTag("NbOfShrsToBeIssd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    
    /// <summary>
    /// Total number of shares that are part of the offer, for example, subscription offer.
    /// </summary>
    [IsoId("_YEpZkw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Total Number Of Shares Offered")]
    [IsoXmlTag("TtlNbOfShrsOfferd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [IsoId("_YEpZmw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Cut Off Days")]
    [IsoXmlTag("CutOffDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? CutOffDays { get; init; } 
    
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). This defines how time sensitive the instruction and withdrawal process is. An offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for a manual agent requires hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [IsoId("_YEpZow7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Automated Offer Program")]
    [IsoXmlTag("DTCAutomtdOfferPrgm")]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    
    /// <summary>
    /// Specifies whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_YEpZqw7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Recycle Cut Off Indicator")]
    [IsoXmlTag("DTCRcyclCutOffInd")]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [IsoId("_YEpZsw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Long Short Payment Indicator")]
    [IsoXmlTag("LngShrtPmtInd")]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [IsoId("_YEpZuw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Oversubscription Type")]
    [IsoXmlTag("OvrsbcptTp")]
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    [IsoId("_YEpZww7vEeuZI5Sr_GAcuA")]
    [DisplayName("Conditional Payment Applicable Flag")]
    [IsoXmlTag("CondlPmtAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("_YEpZyw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Solicitation Dealer Fee Flag")]
    [IsoXmlTag("SlctnDealrFeeFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether positions held in custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_YEpZ0w7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Custody Eligible Flag")]
    [IsoXmlTag("DTCCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the event is eligible for the custody reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_YEpZ2w7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    [IsoXmlTag("DTCReorgCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the event is eligible for the reorganisation deposit service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_YEpZ4w7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    [IsoXmlTag("DTCReorgDpstElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    [IsoId("_YEpZ6w7vEeuZI5Sr_GAcuA")]
    [DisplayName("Surrender Shares To Agent Flag")]
    [IsoXmlTag("SrrndrShrsToAgtFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    [IsoId("_YEpZ8w7vEeuZI5Sr_GAcuA")]
    [DisplayName("Step Up Privilege Flag")]
    [IsoXmlTag("StepUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    [IsoId("_YEpZ-w7vEeuZI5Sr_GAcuA")]
    [DisplayName("Rights Oversubscription Flag")]
    [IsoXmlTag("RghtsOvrsbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the shareholder will be able to round up its subscription in the event its rights are less than the requirement.
    /// </summary>
    [IsoId("_YEpaAw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Rights Round Up Privilege Flag")]
    [IsoXmlTag("RghtsRndUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    [IsoId("_YEpaCw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Rights Transferable Flag")]
    [IsoXmlTag("RghtsTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether rights are available to stockholders as a remedy when they object to the terms of proposed corporate actions. For example, actions can include but are not limited to a merger or a sale of assets. 
    /// This flag will output to Y/N (&quot;true&quot;/&quot;false&quot; or &quot;1&quot;/&quot;0&quot;) or whereas the Option Features Code (DISS) in the standard only used when Yes. 
    /// </summary>
    [IsoId("_PVGIAA7yEeuZI5Sr_GAcuA")]
    [DisplayName("Dissenter Rights Applicable Flag")]
    [IsoXmlTag("DsstrRghtsAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DissenterRightsApplicableFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the certificate of deposit early redemption event is exempt from the presentation of the required legal documentation. When presentation is exempt, the instructing client agrees to maintain such documentation for at least 30 months following payment of the request.
    /// </summary>
    [IsoId("_YEpaEw7vEeuZI5Sr_GAcuA")]
    [DisplayName("Non Exempt Allowed Indicator")]
    [IsoXmlTag("NonXmptAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonExemptAllowedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether instructions are temporarily blocked for the event.
    /// </summary>
    [IsoId("_sdjMQA7vEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Instruction Lockout Indicator")]
    [IsoXmlTag("DTCInstrLckoutInd")]
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; } 
    
    /// <summary>
    /// Details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("_YEpaFQ7vEeuZI5Sr_GAcuA")]
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public CorporateActionSD15? CertificateDetails { get; init; } 
    
    /// <summary>
    /// Country of issue used to determine whether the electable option requires tax exempt or wire information when sending EDS elections via the CAIN message type.
    /// </summary>
    [IsoId("_YEpaHQ7vEeuZI5Sr_GAcuA")]
    [DisplayName("EDS Messaging Country Code")]
    [IsoXmlTag("EDSMsggCtryCd")]
    public CountryCode? EDSMessagingCountryCode { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_YEpaHw7vEeuZI5Sr_GAcuA")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    
    #nullable disable
    
}
