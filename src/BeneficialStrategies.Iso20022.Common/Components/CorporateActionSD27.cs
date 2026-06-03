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
    /// Unambiguous reference to the location/name of a document.
    /// </summary>
    [IsoId("_r_kK9aOEEfCHhuKwuscqyg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Type of notice issued for the corporate action event.
    /// </summary>
    [IsoId("_r_kK-aOEEfCHhuKwuscqyg")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public NoticeType1Code? NoticeType { get; init; }

    /// <summary>
    /// Cash value of the event as declared by the issuer.
    /// </summary>
    [IsoId("_r_kK_aOEEfCHhuKwuscqyg")]
    [DisplayName("Event Cash Value")]
    [IsoXmlTag("EvtCshVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; }

    /// <summary>
    /// Number of shares to be issued.
    /// </summary>
    [IsoId("_r_kLAaOEEfCHhuKwuscqyg")]
    [DisplayName("Number Of Shares To Be Issued")]
    [IsoXmlTag("NbOfShrsToBIssd")]
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; }

    /// <summary>
    /// Total number of shares offered in the event.
    /// </summary>
    [IsoId("_r_kLBaOEEfCHhuKwuscqyg")]
    [DisplayName("Total Number Of Shares Offered")]
    [IsoXmlTag("TtlNbOfShrsOffrd")]
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; }

    /// <summary>
    /// Number of days to cut off.
    /// </summary>
    [IsoId("_r_kLCaOEEfCHhuKwuscqyg")]
    [DisplayName("Cut Off Days")]
    [IsoXmlTag("CutOffDays")]
    public IsoMax3Number? CutOffDays { get; init; }

    /// <summary>
    /// Indicates the DTC Automated Offer Program type.
    /// </summary>
    [IsoId("_r_kLDaOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Automated Offer Program")]
    [IsoXmlTag("DTCAutmtdOfferPrgm")]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; }

    /// <summary>
    /// Indicates whether DTC recycle cut off applies.
    /// </summary>
    [IsoId("_r_kLEaOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Recycle Cut Off Indicator")]
    [IsoXmlTag("DTCRcyclCutOffInd")]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; }

    /// <summary>
    /// Indicates whether the payment is long or short.
    /// </summary>
    [IsoId("_r_kLFaOEEfCHhuKwuscqyg")]
    [DisplayName("Long Short Payment Indicator")]
    [IsoXmlTag("LngShrtPmtInd")]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; }

    /// <summary>
    /// Type of oversubscription for the event.
    /// </summary>
    [IsoId("_r_kLGaOEEfCHhuKwuscqyg")]
    [DisplayName("Oversubscription Type")]
    [IsoXmlTag("OvrsbcptTp")]
    public OversubscriptionType1Code? OversubscriptionType { get; init; }

    /// <summary>
    /// Indicates whether the event requires fractional quantity instruction.
    /// </summary>
    [IsoId("_r_kLHaOEEfCHhuKwuscqyg")]
    [DisplayName("Fractional Quantity Instruction Indicator")]
    [IsoXmlTag("FrctnlQtyInstrInd")]
    public IsoYesNoIndicator? FractionalQuantityInstructionIndicator { get; init; }

    /// <summary>
    /// Indicates whether odd lot tender applies.
    /// </summary>
    [IsoId("_r_kLIaOEEfCHhuKwuscqyg")]
    [DisplayName("Odd Lot Tender Indicator")]
    [IsoXmlTag("OddLotTndrInd")]
    public IsoYesNoIndicator? OddLotTenderIndicator { get; init; }

    /// <summary>
    /// Indicates whether partial election is allowed.
    /// </summary>
    [IsoId("_r_kLJaOEEfCHhuKwuscqyg")]
    [DisplayName("Partial Election Allowed Indicator")]
    [IsoXmlTag("PrtlElctnAllwdInd")]
    public IsoYesNoIndicator? PartialElectionAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether oversubscription applies.
    /// </summary>
    [IsoId("_r_kLKaOEEfCHhuKwuscqyg")]
    [DisplayName("Oversubscription Indicator")]
    [IsoXmlTag("OvrsbcptInd")]
    public IsoYesNoIndicator? OversubscriptionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the event is a priority event.
    /// </summary>
    [IsoId("_r_kLLaOEEfCHhuKwuscqyg")]
    [DisplayName("Priority Event Indicator")]
    [IsoXmlTag("PrtyEvtInd")]
    public IsoYesNoIndicator? PriorityEventIndicator { get; init; }

    /// <summary>
    /// Indicates whether proration applies.
    /// </summary>
    [IsoId("_r_kLMaOEEfCHhuKwuscqyg")]
    [DisplayName("Proration Indicator")]
    [IsoXmlTag("PrratnInd")]
    public IsoYesNoIndicator? ProrationIndicator { get; init; }

    /// <summary>
    /// Indicates whether reinvestment is applicable.
    /// </summary>
    [IsoId("_r_kLNaOEEfCHhuKwuscqyg")]
    [DisplayName("Reinvestment Indicator")]
    [IsoXmlTag("RinvstmtInd")]
    public IsoYesNoIndicator? ReinvestmentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the event is a subscription event.
    /// </summary>
    [IsoId("_r_kLOaOEEfCHhuKwuscqyg")]
    [DisplayName("Subscription Event Indicator")]
    [IsoXmlTag("SbcptEvtInd")]
    public IsoYesNoIndicator? SubscriptionEventIndicator { get; init; }

    /// <summary>
    /// Indicates whether a tax relief is applicable.
    /// </summary>
    [IsoId("_r_kLPaOEEfCHhuKwuscqyg")]
    [DisplayName("Tax Relief Indicator")]
    [IsoXmlTag("TaxRlfInd")]
    public IsoYesNoIndicator? TaxReliefIndicator { get; init; }

    /// <summary>
    /// DTC instruction lockout type.
    /// </summary>
    [IsoId("_r_kLQaOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Instruction Lockout Indicator")]
    [IsoXmlTag("DTCInstrLckoutInd")]
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; }

    /// <summary>
    /// Supplementary data for each certificate.
    /// </summary>
    [IsoId("_r_kLRaOEEfCHhuKwuscqyg")]
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public ValueList<CorporateActionSD26> CertificateDetails { get; init; } = [];

    /// <summary>
    /// Country code used for EDS messaging.
    /// </summary>
    [IsoId("_r_kLSaOEEfCHhuKwuscqyg")]
    [DisplayName("EDS Messaging Country Code")]
    [IsoXmlTag("EDSMsgCtryCode")]
    public CountryCode? EDSMessagingCountryCode { get; init; }

    /// <summary>
    /// Reference number for RDP.
    /// </summary>
    [IsoId("_r_kLTaOEEfCHhuKwuscqyg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Total quantity of securities called by DTC.
    /// </summary>
    [IsoId("_r_kLUaOEEfCHhuKwuscqyg")]
    [DisplayName("DTC Total Called Quantity")]
    [IsoXmlTag("DTCTtlClldQty")]
    public FinancialInstrumentQuantity34Choice_? DTCTotalCalledQuantity { get; init; }
}
