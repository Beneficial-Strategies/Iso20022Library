// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
[IsoId("_QAKbh5JKEeuAlLVx8pyt3w")]
[DisplayName("Common Financial Instrument Attributes")]
public record CommonFinancialInstrumentAttributes11
{
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_QCG8QZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Status")]
    [IsoXmlTag("SctySts")]
    public SecurityStatus3Choice_? SecurityStatus { get; init; }

    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_QCG8SZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    public FinancialInstrumentName2? FinancialInstrumentName { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_QCG8S5JKEeuAlLVx8pyt3w")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_QCG8U5JKEeuAlLVx8pyt3w")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateNumber { get; init; }

    /// <summary>
    /// Version number assigned to the contract associated with the security.
    /// </summary>
    [IsoId("_QCG8VZJKEeuAlLVx8pyt3w")]
    [DisplayName("Contract Version Number")]
    [IsoXmlTag("CtrctVrsnNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ContractVersionNumber { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_QCG8V5JKEeuAlLVx8pyt3w")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_QCG8WZJKEeuAlLVx8pyt3w")]
    [DisplayName("Tax Lot Number")]
    [IsoXmlTag("TaxLotNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? TaxLotNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_QCG8W5JKEeuAlLVx8pyt3w")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? PoolNumber { get; init; }

    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_QCG8Y5JKEeuAlLVx8pyt3w")]
    [DisplayName("Covered Indicator")]
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CoveredIndicator { get; init; }

    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_QCG8ZZJKEeuAlLVx8pyt3w")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public LegalRestrictions4Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Position limits are created for the purpose of maintaining stable and fair markets. Contracts held by one individual investor with different brokers may be combined in order to gauge accurately the level of control held by one party. ||Each option and futures contract will have varying position limits.
    /// </summary>
    [IsoId("_QCG8Z5JKEeuAlLVx8pyt3w")]
    [DisplayName("Position Limit")]
    [IsoXmlTag("PosLmt")]
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; init; }

    /// <summary>
    /// Near-term position limit for the instrument.
    /// </summary>
    [IsoId("_QCG8b5JKEeuAlLVx8pyt3w")]
    [DisplayName("Near Term Position Limit")]
    [IsoXmlTag("NearTermPosLmt")]
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; init; }

    /// <summary>
    /// Original Date/time at which the security is listed at the specific exchange or trading venue.
    /// </summary>
    [IsoId("_QCG8d5JKEeuAlLVx8pyt3w")]
    [DisplayName("Listing Date")]
    [IsoXmlTag("ListgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ListingDate { get; init; }

    /// <summary>
    /// Date/time at which positions are struck to note which parties are entitled to receive the entitlement to a corporate event or vote at a meeting.
    /// </summary>
    [IsoId("_QCG8eZJKEeuAlLVx8pyt3w")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RecordDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_QCG8e5JKEeuAlLVx8pyt3w")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_QCG8fZJKEeuAlLVx8pyt3w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Purpose { get; init; }

    /// <summary>
    /// Information allowing the classification of a financial instrument, for example, with its ISO CFI (Classification of Financial Instrument) or product type.
    /// </summary>
    [IsoId("_QCG8f5JKEeuAlLVx8pyt3w")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2? ClassificationType { get; init; }

    /// <summary>
    /// Details regarding the issuance of an asset.
    /// </summary>
    [IsoId("_QCG8gZJKEeuAlLVx8pyt3w")]
    [DisplayName("Issuance")]
    [IsoXmlTag("Issnc")]
    public Issuance6? Issuance { get; init; }

    /// <summary>
    /// Market(s) on which the security is traded.
    /// </summary>
    [IsoId("_QCG8g5JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Market")]
    [IsoXmlTag("TradgMkt")]
    public TradingParameters2? TradingMarket { get; init; }

    /// <summary>
    /// Indicates the spread to benchmark details of an indication of interest.
    /// </summary>
    [IsoId("_QCG8hZJKEeuAlLVx8pyt3w")]
    [DisplayName("Spread And Benchmark Curve")]
    [IsoXmlTag("SprdAndBchmkCrv")]
    public BenchmarkCurve6? SpreadAndBenchmarkCurve { get; init; }

    /// <summary>
    /// Represents the type of put.
    /// </summary>
    [IsoId("_QCG8h5JKEeuAlLVx8pyt3w")]
    [DisplayName("Put Type")]
    [IsoXmlTag("PutTp")]
    public PutType3Choice_? PutType { get; init; }

    /// <summary>
    /// Represents the type of call.
    /// </summary>
    [IsoId("_QCG8iZJKEeuAlLVx8pyt3w")]
    [DisplayName("Call Type")]
    [IsoXmlTag("CallTp")]
    public CallType3Choice_? CallType { get; init; }

    /// <summary>
    /// Indicates whether a security is interchangeable, ie, the security is allowed to be replaced by another security, without loss of value.
    /// </summary>
    [IsoId("_QCG8i5JKEeuAlLVx8pyt3w")]
    [DisplayName("Fungible Indicator")]
    [IsoXmlTag("FngbInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FungibleIndicator { get; init; }

    /// <summary>
    /// Indicates whether the details of the security are to be made available to the market, or kept private between ICSDs and agency network.
    /// </summary>
    [IsoId("_QCG8jZJKEeuAlLVx8pyt3w")]
    [DisplayName("Confidential")]
    [IsoXmlTag("Cnfdtl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Confidential { get; init; }

    /// <summary>
    /// The sale of securities directly to private persons, institutional investors, or both outside a public offering. Such non-public deals (often without a publicly available prospectus) closing through the ICSDs are placed directly with investors.
    /// </summary>
    [IsoId("_QCG8j5JKEeuAlLVx8pyt3w")]
    [DisplayName("Private Placement")]
    [IsoXmlTag("PrvtPlcmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PrivatePlacement { get; init; }

    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    [IsoId("_QCG8kZJKEeuAlLVx8pyt3w")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; }

    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_QCG8k5JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Period")]
    [IsoXmlTag("ConvsPrd")]
    public DateTimePeriod1? ConversionPeriod { get; init; }

    /// <summary>
    /// Number of target securities for the conversion.
    /// </summary>
    [IsoId("_QCG8lZJKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Numerator")]
    [IsoXmlTag("ConvsRatioNmrtr")]
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; init; }

    /// <summary>
    /// Number of held securities for the conversion.
    /// </summary>
    [IsoId("_QCG8l5JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Denominator")]
    [IsoXmlTag("ConvsRatioDnmtr")]
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; init; }

    /// <summary>
    /// Primary place of deposit.
    /// </summary>
    [IsoId("_QCG8mZJKEeuAlLVx8pyt3w")]
    [DisplayName("Primary Place Of Deposit")]
    [IsoXmlTag("PmryPlcOfDpst")]
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; init; }

    /// <summary>
    /// Indicates whether the notional amount value is to be traded in either an amount or in units.
    /// </summary>
    [IsoId("_QCG8m5JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public UnitOrFaceAmount1Choice_? TradingMethod { get; init; }

    /// <summary>
    /// Indicates the TEFRA rule under which the security is issued.
    /// </summary>
    [IsoId("_QCG8nZJKEeuAlLVx8pyt3w")]
    [DisplayName("TEFRA Rule")]
    [IsoXmlTag("TEFRARule")]
    public TEFRARules3Choice_? TEFRARule { get; init; }

    /// <summary>
    /// Identifies the series number.
    /// </summary>
    [IsoId("_QCG8n5JKEeuAlLVx8pyt3w")]
    [DisplayName("Serie Number")]
    [IsoXmlTag("SrNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? SerieNumber { get; init; }

    /// <summary>
    /// Identifier that links multiple security classes.
    /// </summary>
    [IsoId("_QCG8oZJKEeuAlLVx8pyt3w")]
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Class { get; init; }

    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_QCG8o5JKEeuAlLVx8pyt3w")]
    [DisplayName("Withholding Tax Regime")]
    [IsoXmlTag("WhldgTaxRgm")]
    public SecurityWithHoldingTax1? WithholdingTaxRegime { get; init; }

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_QCG8pZJKEeuAlLVx8pyt3w")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; init; }

    /// <summary>
    /// Indicates the physical form of the securities on the closing date.
    /// </summary>
    [IsoId("_QCG8p5JKEeuAlLVx8pyt3w")]
    [DisplayName("Initial Physical Form")]
    [IsoXmlTag("InitlPhysForm")]
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; init; }

    /// <summary>
    /// Indicates the physical form of the securities after the exchange of the initial certificate issued on the closing date.
    /// </summary>
    [IsoId("_QCG8qZJKEeuAlLVx8pyt3w")]
    [DisplayName("After Exchange Physical Form")]
    [IsoXmlTag("AftrXchgPhysForm")]
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; init; }

    /// <summary>
    /// Entity appointed by the ICSDs to provide safekeeping for securities in new global note (NGN) form.
    /// </summary>
    [IsoId("_QCG8q5JKEeuAlLVx8pyt3w")]
    [DisplayName("Common Safekeeper")]
    [IsoXmlTag("CmonSfkpr")]
    public PartyIdentification177Choice_? CommonSafekeeper { get; init; }

    /// <summary>
    /// Indicates the type of redemption at maturity.
    /// </summary>
    [IsoId("_QCG8rZJKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Type")]
    [IsoXmlTag("RedTp")]
    public MaturityRedemptionType3Choice_? RedemptionType { get; init; }

    /// <summary>
    /// ISO currency for the payment of the cash proceeds.
    /// </summary>
    [IsoId("_QCG8r5JKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Payment Currency")]
    [IsoXmlTag("RedPmtCcy")]
    public ActiveCurrencyCode? RedemptionPaymentCurrency { get; init; }

    /// <summary>
    /// Regulatory restriction(s) linked to the security.
    /// </summary>
    [IsoId("_QCG8sZJKEeuAlLVx8pyt3w")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SecurityRestriction3? Restriction { get; init; }

    /// <summary>
    /// Specifies the date from which the financial instrument identification is valid.
    /// </summary>
    [IsoId("_QCG8s5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification Validity")]
    [IsoXmlTag("FinInstrmIdVldty")]
    public FinancialInstrumentIdentificationValidity3? FinancialInstrumentIdentificationValidity { get; init; }

    /// <summary>
    /// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
    /// </summary>
    [IsoId("_QCG8tZJKEeuAlLVx8pyt3w")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInformation17? SettlementInformation { get; init; }

    /// <summary>
    /// Indicates the form of the financial Instrument.
    /// </summary>
    [IsoId("_QCG8t5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Form")]
    [IsoXmlTag("FinInstrmForm")]
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; init; }

    /// <summary>
    /// Details (name, e-mail address and/or telephone number) of the person requesting the allocation of the ISIN used as a point of reference in case further clarifications are required.
    /// </summary>
    [IsoId("_QCG8uZJKEeuAlLVx8pyt3w")]
    [DisplayName("Contact Name")]
    [IsoXmlTag("CtctNm")]
    public Organisation38? ContactName { get; init; }

    /// <summary>
    /// Entity appointed by the issuer to structure and lead the placement of a syndicated issue.
    /// </summary>
    [IsoId("_QCG8u5JKEeuAlLVx8pyt3w")]
    [DisplayName("Lead Manager")]
    [IsoXmlTag("LeadMgr")]
    public Organisation38? LeadManager { get; init; }

    /// <summary>
    /// Main party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_QCG8vZJKEeuAlLVx8pyt3w")]
    [DisplayName("Principal Paying Agent")]
    [IsoXmlTag("PrncplPngAgt")]
    public Organisation38? PrincipalPayingAgent { get; init; }

    /// <summary>
    /// Additional party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_QCG8v5JKEeuAlLVx8pyt3w")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public Organisation38? PayingAgent { get; init; }

    /// <summary>
    /// Entity appointed by the relevant clearing system as a depository for instruments issued in global or definitive form. The depository keeps the securities for safekeeping purposes on behalf of the clearing system(s).
    /// </summary>
    [IsoId("_QCG8wZJKEeuAlLVx8pyt3w")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public Organisation38? Depository { get; init; }

    /// <summary>
    /// Entity(ies), asset(s) or security(ies) on which the credit responsibility lies as identified in the documentation.
    /// </summary>
    [IsoId("_QCG8w5JKEeuAlLVx8pyt3w")]
    [DisplayName("Underlying Risk")]
    [IsoXmlTag("UndrlygRsk")]
    public Organisation38? UnderlyingRisk { get; init; }

    /// <summary>
    /// Defines how the CSD is linked to the security.
    /// </summary>
    [IsoId("_QCG8xZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security CSD Link")]
    [IsoXmlTag("SctyCSDLk")]
    public SecurityCSDLink7? SecurityCSDLink { get; init; }
}
