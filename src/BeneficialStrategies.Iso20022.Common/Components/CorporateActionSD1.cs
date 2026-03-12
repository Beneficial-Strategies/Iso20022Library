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
[IsoId("_1hhk0jL3EeKU9IrkkToqcw_1235439158")]
[DisplayName("Corporate Action SD")]
public partial record CorporateActionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1hhk0zL3EeKU9IrkkToqcw_1288619987")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC&apos;s nominee name.
    /// </summary>
    [IsoId("_1hhk1DL3EeKU9IrkkToqcw_-591685653")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public NoticeType1Code? NoticeType { get; init; } 
    
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [IsoId("_1hhk1TL3EeKU9IrkkToqcw_-596399028")]
    [DisplayName("Event Cash Value")]
    [IsoXmlTag("EvtCshVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [IsoId("_1hhk1jL3EeKU9IrkkToqcw_-1707310447")]
    [DisplayName("Number Of Shares To Be Issued")]
    [IsoXmlTag("NbOfShrsToBeIssd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    
    /// <summary>
    /// Total number of shares that are part of the offer for example subscription offer.
    /// </summary>
    [IsoId("_1hrV0DL3EeKU9IrkkToqcw_707351209")]
    [DisplayName("Total Number Of Shares Offered")]
    [IsoXmlTag("TtlNbOfShrsOfferd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [IsoId("_1hrV0TL3EeKU9IrkkToqcw_-721336871")]
    [DisplayName("Cut Off Days")]
    [IsoXmlTag("CutOffDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? CutOffDays { get; init; } 
    
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). It defines how time sensitive instruction and withdrawal process is. Offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for manual agent require hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [IsoId("_1hrV0jL3EeKU9IrkkToqcw_1693324785")]
    [DisplayName("DTC Automated Offer Program")]
    [IsoXmlTag("DTCAutomtdOfferPrgm")]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    
    /// <summary>
    /// Indicates whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1hrV0zL3EeKU9IrkkToqcw_582413366")]
    [DisplayName("DTC Recycle Cut Off Indicator")]
    [IsoXmlTag("DTCRcyclCutOffInd")]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    
    /// <summary>
    /// Denotes whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [IsoId("_1hrV1DL3EeKU9IrkkToqcw_2147412054")]
    [DisplayName("Long Short Payment Indicator")]
    [IsoXmlTag("LngShrtPmtInd")]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [IsoId("_1hrV1TL3EeKU9IrkkToqcw_-1561608216")]
    [DisplayName("Oversubscription Type")]
    [IsoXmlTag("OvrsbcptTp")]
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    [IsoId("_1hrV1jL3EeKU9IrkkToqcw_1622447661")]
    [DisplayName("Conditional Payment Applicable Flag")]
    [IsoXmlTag("CondlPmtAplblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("_1h0fwDL3EeKU9IrkkToqcw_-931426307")]
    [DisplayName("Solicitation Dealer Fee Flag")]
    [IsoXmlTag("SlctnDealrFeeFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether positions held in Custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1h0fwTL3EeKU9IrkkToqcw_1483235349")]
    [DisplayName("DTC Custody Eligible Flag")]
    [IsoXmlTag("DTCCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the event is eligible for Custody Reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1h0fwjL3EeKU9IrkkToqcw_372323930")]
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    [IsoXmlTag("DTCReorgCtdyElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the event is eligible for Reorganisation Deposit Service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1h0fwzL3EeKU9IrkkToqcw_-1182453653")]
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    [IsoXmlTag("DTCReorgDpstElgblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    [IsoId("_1jAykDL3EeKU9IrkkToqcw_2001602224")]
    [DisplayName("Surrender Shares To Agent Flag")]
    [IsoXmlTag("SrrndrShrsToAgtFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    [IsoId("_1jKjkDL3EeKU9IrkkToqcw_121296584")]
    [DisplayName("Step Up Privilege Flag")]
    [IsoXmlTag("StepUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    [IsoId("_1jKjkTL3EeKU9IrkkToqcw_-1371671102")]
    [DisplayName("Rights Oversubscription Flag")]
    [IsoXmlTag("RghtsOvrsbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the shareholder will be able to round up his/her subscription in the event his/her rights are less than the requirement.
    /// </summary>
    [IsoId("_1jKjkjL3EeKU9IrkkToqcw_1812384775")]
    [DisplayName("Rights Round Up Privilege Flag")]
    [IsoXmlTag("RghtsRndUpPrvlgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    [IsoId("_1jKjkzL3EeKU9IrkkToqcw_-67920865")]
    [DisplayName("Rights Transferable Flag")]
    [IsoXmlTag("RghtsTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    
    /// <summary>
    /// Provides details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("_1jKjlDL3EeKU9IrkkToqcw_973587023")]
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public CorporateActionSD5? CertificateDetails { get; init; } 
    
    
    #nullable disable
    
}
