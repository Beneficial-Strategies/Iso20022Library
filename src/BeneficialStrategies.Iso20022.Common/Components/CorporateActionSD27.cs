// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides supplementary data for corporate action events.
/// </summary>
[IsoId("_r_kK8aOEEfCHhuKwuscqyg")]
[DisplayName("Corporate Action SD27")]
public record CorporateActionSD27
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_sH3yY6OEEfCHhuKwuscqyg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public Max350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC's nominee name.
    /// </summary>
    [IsoId("_sH3yZaOEEfCHhuKwuscqyg")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public NoticeType1Code? NoticeType { get; init; }

    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [IsoId("_sH3ybaOEEfCHhuKwuscqyg")]
    [DisplayName("Event Cash Value")]
    [IsoXmlTag("EvtCshVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; }

    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [IsoId("_sH3ye6OEEfCHhuKwuscqyg")]
    [DisplayName("Number Of Shares To Be Issued")]
    [IsoXmlTag("NbOfShrsToBeIssd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public DecimalNumber? NumberOfSharesToBeIssued { get; init; }

    /// <summary>
    /// Total number of shares that are part of the offer, for example, subscription offer.
    /// </summary>
    [IsoId("_sH3yg6OEEfCHhuKwuscqyg")]
    [DisplayName("Total Number Of Shares Offered")]
    [IsoXmlTag("TtlNbOfShrsOfferd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public DecimalNumber? TotalNumberOfSharesOffered { get; init; }

    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [IsoId("_sH4Zd6OEEfCHhuKwuscqyg")]
    [DisplayName("Cut Off Days")]
    [IsoXmlTag("CutOffDays")]
    public Max3Number? CutOffDays { get; init; }

    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). This defines how time sensitive the instruction and withdrawal process is. An offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for a manual agent requires hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [IsoId("_sH4Zf6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Automated Offer Program")]
    [IsoXmlTag("DTCAutomtdOfferPrgm")]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; }

    /// <summary>
    /// Specifies whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_sH4Zh6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Recycle Cut Off Indicator")]
    [IsoXmlTag("DTCRcyclCutOffInd")]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; }

    /// <summary>
    /// Specifies whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [IsoId("_sH4Zj6OEEfCHhuKwuscqyg")]
    [DisplayName("Long Short Payment Indicator")]
    [IsoXmlTag("LngShrtPmtInd")]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; }

    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [IsoId("_sH4Zl6OEEfCHhuKwuscqyg")]
    [DisplayName("Oversubscription Type")]
    [IsoXmlTag("OvrsbcptTp")]
    public OversubscriptionType1Code? OversubscriptionType { get; init; }

    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH4Zn6OEEfCHhuKwuscqyg")]
    [DisplayName("Conditional Payment Applicable Flag")]
    [IsoXmlTag("CondlPmtAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? ConditionalPaymentApplicableFlag { get; init; }

    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH4Zp6OEEfCHhuKwuscqyg")]
    [DisplayName("Solicitation Dealer Fee Flag")]
    [IsoXmlTag("SlctnDealrFeeFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? SolicitationDealerFeeFlag { get; init; }

    /// <summary>
    /// Indicates whether positions held in custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH4Zr6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Custody Eligible Flag")]
    [IsoXmlTag("DTCCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? DTCCustodyEligibleFlag { get; init; }

    /// <summary>
    /// Indicates whether the event is eligible for the custody reorganisation service at DTC (The Depository Trust Corporation).|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH4Zt6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    [IsoXmlTag("DTCReorgCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; }

    /// <summary>
    /// Indicates whether the event is eligible for the reorganisation deposit service at DTC (The Depository Trust Corporation).|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH4Zv6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    [IsoXmlTag("DTCReorgDpstElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; }

    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AgaOEEfCHhuKwuscqyg")]
    [DisplayName("Surrender Shares To Agent Flag")]
    [IsoXmlTag("SrrndrShrsToAgtFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? SurrenderSharesToAgentFlag { get; init; }

    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AiaOEEfCHhuKwuscqyg")]
    [DisplayName("Step Up Privilege Flag")]
    [IsoXmlTag("StepUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? StepUpPrivilegeFlag { get; init; }

    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AkaOEEfCHhuKwuscqyg")]
    [DisplayName("Rights Oversubscription Flag")]
    [IsoXmlTag("RghtsOvrsbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? RightsOversubscriptionFlag { get; init; }

    /// <summary>
    /// Indicates whether the shareholder will be able to round up its subscription in the event its rights are less than the requirement.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AmaOEEfCHhuKwuscqyg")]
    [DisplayName("Rights Round Up Privilege Flag")]
    [IsoXmlTag("RghtsRndUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; }

    /// <summary>
    /// Indicates whether rights can be transferred.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AoaOEEfCHhuKwuscqyg")]
    [DisplayName("Rights Transferable Flag")]
    [IsoXmlTag("RghtsTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? RightsTransferableFlag { get; init; }

    /// <summary>
    /// Indicates whether rights are available to stockholders as a remedy when they object to the terms of proposed corporate actions. For example, actions can include but are not limited to a merger or a sale of assets.|This flag will output to Y/N ("true"/"false" or "1"/"0") or whereas the Option Features Code (DISS) in the standard only used when Yes.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5AqaOEEfCHhuKwuscqyg")]
    [DisplayName("Dissenter Rights Applicable Flag")]
    [IsoXmlTag("DsstrRghtsAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? DissenterRightsApplicableFlag { get; init; }

    /// <summary>
    /// Indicates whether the certificate of deposit early redemption event is exempt from the presentation of the required legal documentation. When presentation is exempt, the instructing client agrees to maintain such documentation for at least 30 months following payment of the request.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5Aq6OEEfCHhuKwuscqyg")]
    [DisplayName("Non Exempt Allowed Indicator")]
    [IsoXmlTag("NonXmptAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? NonExemptAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether instructions are temporarily blocked for the event.
    /// </summary>
    [IsoId("_sH5AraOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Instruction Lockout Indicator")]
    [IsoXmlTag("DTCInstrLckoutInd")]
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; }

    /// <summary>
    /// Details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("_sH5Ar6OEEfCHhuKwuscqyg")]
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public ValueList<CorporateActionSD26> CertificateDetails { get; init; } = [];

    /// <summary>
    /// Country of issue used to determine whether the electable option requires tax exempt or wire information when sending EDS elections via the CAIN message type.
    /// </summary>
    [IsoId("_sH5At6OEEfCHhuKwuscqyg")]
    [DisplayName("EDS Messaging Country Code")]
    [IsoXmlTag("EDSMsggCtryCd")]
    public CountryCode? EDSMessagingCountryCode { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_sH5AuaOEEfCHhuKwuscqyg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public Exact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Identifies events that offer instruction processing specific to foreign tax elections.|Yes: applicable.|No: not applicable.|When absent, means No.
    /// </summary>
    [IsoId("_sH5Au6OEEfCHhuKwuscqyg")]
    [DisplayName("DTC Foreign Tax Election Flag")]
    [IsoXmlTag("DTCFrgnTaxElctnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public YesNoIndicator? DTCForeignTaxElectionFlag { get; init; }

    /// <summary>
    /// Total Called Quantity for secuirty held at DTC including FAST and Registered positions.
    /// </summary>
    [IsoId("_1LkngKOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Total Called Quantity")]
    [IsoXmlTag("DTCTtlClldQty")]
    public FinancialInstrumentQuantity34Choice_? DTCTotalCalledQuantity { get; init; }
}
