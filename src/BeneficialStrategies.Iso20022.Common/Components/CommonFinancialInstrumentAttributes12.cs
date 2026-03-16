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
[IsoId("_QKNvZ5JKEeuAlLVx8pyt3w")]
[DisplayName("Common Financial Instrument Attributes")]
public record CommonFinancialInstrumentAttributes12
{
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_QMJpEZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Status")]
    [IsoXmlTag("SctySts")]
    public SecurityStatus3Choice_? SecurityStatus { get; init; }

    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_QMJpGZJKEeuAlLVx8pyt3w")]
    [DisplayName("ISO Security Long Name")]
    [IsoXmlTag("ISOSctyLngNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ISOSecurityLongName { get; init; }

    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_QMJpG5JKEeuAlLVx8pyt3w")]
    [DisplayName("ISO Security Short Name")]
    [IsoXmlTag("ISOSctyShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ISOSecurityShortName { get; init; }

    /// <summary>
    /// Defines the date since when the name of the security is valid.
    /// </summary>
    [IsoId("_QMJpHZJKEeuAlLVx8pyt3w")]
    [DisplayName("Name Valid From")]
    [IsoXmlTag("NmVldFr")]
    public DateAndDateTime2Choice_? NameValidFrom { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_QMJpH5JKEeuAlLVx8pyt3w")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_QMJpJ5JKEeuAlLVx8pyt3w")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateNumber { get; init; }

    /// <summary>
    /// Version number assigned to the contract associated with the security.
    /// </summary>
    [IsoId("_QMJpKZJKEeuAlLVx8pyt3w")]
    [DisplayName("Contract Version Number")]
    [IsoXmlTag("CtrctVrsnNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ContractVersionNumber { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_QMJpK5JKEeuAlLVx8pyt3w")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_QMJpLZJKEeuAlLVx8pyt3w")]
    [DisplayName("Tax Lot Number")]
    [IsoXmlTag("TaxLotNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? TaxLotNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_QMJpL5JKEeuAlLVx8pyt3w")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? PoolNumber { get; init; }

    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_QMJpN5JKEeuAlLVx8pyt3w")]
    [DisplayName("Covered Indicator")]
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CoveredIndicator { get; init; }

    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_QMJpOZJKEeuAlLVx8pyt3w")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public LegalRestrictions4Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Position limits are created for the purpose of maintaining stable and fair markets. Contracts held by one individual investor with different brokers may be combined in order to gauge accurately the level of control held by one party. ||Each option and futures contract will have varying position limits.
    /// </summary>
    [IsoId("_QMJpO5JKEeuAlLVx8pyt3w")]
    [DisplayName("Position Limit")]
    [IsoXmlTag("PosLmt")]
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; init; }

    /// <summary>
    /// Near-term position limit for the instrument.
    /// </summary>
    [IsoId("_QMJpQ5JKEeuAlLVx8pyt3w")]
    [DisplayName("Near Term Position Limit")]
    [IsoXmlTag("NearTermPosLmt")]
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; init; }

    /// <summary>
    /// Original Date/time at which the security is listed at the specific exchange or trading venue.
    /// </summary>
    [IsoId("_QMJpS5JKEeuAlLVx8pyt3w")]
    [DisplayName("Listing Date")]
    [IsoXmlTag("ListgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ListingDate { get; init; }

    /// <summary>
    /// Date/time at which positions are struck to note which parties are entitled to receive the entitlement to a corporate event or vote at a meeting.
    /// </summary>
    [IsoId("_QMJpTZJKEeuAlLVx8pyt3w")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RecordDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_QMJpT5JKEeuAlLVx8pyt3w")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_QMJpUZJKEeuAlLVx8pyt3w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Purpose { get; init; }

    /// <summary>
    /// Information allowing the classification of a financial instrument, for example, with its ISO CFI (Classification of Financial Instrument) or product type.
    /// </summary>
    [IsoId("_QMJpU5JKEeuAlLVx8pyt3w")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2? ClassificationType { get; init; }

    /// <summary>
    /// Details regarding the issuance of an asset.
    /// </summary>
    [IsoId("_QMJpVZJKEeuAlLVx8pyt3w")]
    [DisplayName("Issuance")]
    [IsoXmlTag("Issnc")]
    public Issuance5? Issuance { get; init; }

    /// <summary>
    /// Market(s) on which the security is traded.
    /// </summary>
    [IsoId("_QMJpV5JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Market")]
    [IsoXmlTag("TradgMkt")]
    public ValueList<TradingParameters2> TradingMarket { get; init; } = [];

    /// <summary>
    /// Indicates the spread to benchmark details of an indication of interest.
    /// </summary>
    [IsoId("_QMJpWZJKEeuAlLVx8pyt3w")]
    [DisplayName("Spread And Benchmark Curve")]
    [IsoXmlTag("SprdAndBchmkCrv")]
    public ValueList<BenchmarkCurve6> SpreadAndBenchmarkCurve { get; init; } = [];

    /// <summary>
    /// Represents the type of put.
    /// </summary>
    [IsoId("_QMJpW5JKEeuAlLVx8pyt3w")]
    [DisplayName("Put Type")]
    [IsoXmlTag("PutTp")]
    public PutType3Choice_? PutType { get; init; }

    /// <summary>
    /// Represents the type of call.
    /// </summary>
    [IsoId("_QMJpXZJKEeuAlLVx8pyt3w")]
    [DisplayName("Call Type")]
    [IsoXmlTag("CallTp")]
    public CallType3Choice_? CallType { get; init; }

    /// <summary>
    /// Indicates whether a security is interchangeable, ie, the security is allowed to be replaced by another security, without loss of value.
    /// </summary>
    [IsoId("_QMJpX5JKEeuAlLVx8pyt3w")]
    [DisplayName("Fungible Indicator")]
    [IsoXmlTag("FngbInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FungibleIndicator { get; init; }

    /// <summary>
    /// Indicates whether the details of the security are to be made available to the market, or kept private between ICSDs and agency network.
    /// </summary>
    [IsoId("_QMJpYZJKEeuAlLVx8pyt3w")]
    [DisplayName("Confidential")]
    [IsoXmlTag("Cnfdtl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Confidential { get; init; }

    /// <summary>
    /// The sale of securities directly to private persons, institutional investors, or both outside a public offering. Such non-public deals (often without a publicly available prospectus) closing through the ICSDs are placed directly with investors.
    /// </summary>
    [IsoId("_QMJpY5JKEeuAlLVx8pyt3w")]
    [DisplayName("Private Placement")]
    [IsoXmlTag("PrvtPlcmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PrivatePlacement { get; init; }

    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    [IsoId("_QMJpZZJKEeuAlLVx8pyt3w")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; }

    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_QMJpZ5JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Period")]
    [IsoXmlTag("ConvsPrd")]
    public DateTimePeriod1? ConversionPeriod { get; init; }

    /// <summary>
    /// Number of target securities for the conversion.
    /// </summary>
    [IsoId("_QMJpaZJKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Numerator")]
    [IsoXmlTag("ConvsRatioNmrtr")]
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; init; }

    /// <summary>
    /// Number of held securities for the conversion.
    /// </summary>
    [IsoId("_QMJpa5JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Denominator")]
    [IsoXmlTag("ConvsRatioDnmtr")]
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; init; }

    /// <summary>
    /// Primary place of deposit.
    /// </summary>
    [IsoId("_QMJpbZJKEeuAlLVx8pyt3w")]
    [DisplayName("Primary Place Of Deposit")]
    [IsoXmlTag("PmryPlcOfDpst")]
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; init; }

    /// <summary>
    /// Indicates whether the notional amount value is to be traded in either an amount or in units.
    /// </summary>
    [IsoId("_QMJpb5JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public UnitOrFaceAmount1Choice_? TradingMethod { get; init; }

    /// <summary>
    /// Indicates the TEFRA rule under which the security is issued.
    /// </summary>
    [IsoId("_QMJpcZJKEeuAlLVx8pyt3w")]
    [DisplayName("TEFRA Rule")]
    [IsoXmlTag("TEFRARule")]
    public TEFRARules3Choice_? TEFRARule { get; init; }

    /// <summary>
    /// Identifies the series number.
    /// </summary>
    [IsoId("_QMJpc5JKEeuAlLVx8pyt3w")]
    [DisplayName("Serie Number")]
    [IsoXmlTag("SrNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? SerieNumber { get; init; }

    /// <summary>
    /// Identifier that links multiple security classes.
    /// </summary>
    [IsoId("_QMJpdZJKEeuAlLVx8pyt3w")]
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Class { get; init; }

    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_QMJpd5JKEeuAlLVx8pyt3w")]
    [DisplayName("Withholding Tax Regime")]
    [IsoXmlTag("WhldgTaxRgm")]
    public ValueList<SecurityWithHoldingTax1> WithholdingTaxRegime { get; init; } = [];

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_QMJpeZJKEeuAlLVx8pyt3w")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; init; }

    /// <summary>
    /// Indicates the physical form of the securities on the closing date.
    /// </summary>
    [IsoId("_QMJpe5JKEeuAlLVx8pyt3w")]
    [DisplayName("Initial Physical Form")]
    [IsoXmlTag("InitlPhysForm")]
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; init; }

    /// <summary>
    /// Indicates the physical form of the securities after the exchange of the initial certificate issued on the closing date.
    /// </summary>
    [IsoId("_QMJpfZJKEeuAlLVx8pyt3w")]
    [DisplayName("After Exchange Physical Form")]
    [IsoXmlTag("AftrXchgPhysForm")]
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; init; }

    /// <summary>
    /// Entity appointed by the ICSDs to provide safekeeping for securities in new global note (NGN) form.
    /// </summary>
    [IsoId("_QMJpf5JKEeuAlLVx8pyt3w")]
    [DisplayName("Common Safekeeper")]
    [IsoXmlTag("CmonSfkpr")]
    public PartyIdentification177Choice_? CommonSafekeeper { get; init; }

    /// <summary>
    /// Indicates the type of redemption at maturity.
    /// </summary>
    [IsoId("_QMJpgZJKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Type")]
    [IsoXmlTag("RedTp")]
    public MaturityRedemptionType3Choice_? RedemptionType { get; init; }

    /// <summary>
    /// ISO currency for the payment of the cash proceeds.
    /// </summary>
    [IsoId("_QMJpg5JKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Payment Currency")]
    [IsoXmlTag("RedPmtCcy")]
    public ActiveCurrencyCode? RedemptionPaymentCurrency { get; init; }

    /// <summary>
    /// Regulatory restriction(s) linked to the security.
    /// </summary>
    [IsoId("_QMJphZJKEeuAlLVx8pyt3w")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<SecurityRestriction3> Restriction { get; init; } = [];

    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_QMJph5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
    /// </summary>
    [IsoId("_QMJpiZJKEeuAlLVx8pyt3w")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public ValueList<SettlementInformation17> SettlementInformation { get; init; } = [];

    /// <summary>
    /// Indicates the form of the financial Instrument.
    /// </summary>
    [IsoId("_QMJpi5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Form")]
    [IsoXmlTag("FinInstrmForm")]
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; init; }

    /// <summary>
    /// Details (name, e-mail address and/or telephone number) of the person requesting the allocation of the ISIN used as a point of reference in case further clarifications are required.
    /// </summary>
    [IsoId("_QMJpjZJKEeuAlLVx8pyt3w")]
    [DisplayName("Contact Name")]
    [IsoXmlTag("CtctNm")]
    public Organisation38? ContactName { get; init; }

    /// <summary>
    /// Entity appointed by the issuer to structure and lead the placement of a syndicated issue.
    /// </summary>
    [IsoId("_QMJpj5JKEeuAlLVx8pyt3w")]
    [DisplayName("Lead Manager")]
    [IsoXmlTag("LeadMgr")]
    public Organisation38? LeadManager { get; init; }

    /// <summary>
    /// Main party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_QMJpkZJKEeuAlLVx8pyt3w")]
    [DisplayName("Principal Paying Agent")]
    [IsoXmlTag("PrncplPngAgt")]
    public Organisation38? PrincipalPayingAgent { get; init; }

    /// <summary>
    /// Additional party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_QMJpk5JKEeuAlLVx8pyt3w")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public Organisation38? PayingAgent { get; init; }

    /// <summary>
    /// Entity appointed by the relevant clearing system as a depository for instruments issued in global or definitive form. The depository keeps the securities for safekeeping purposes on behalf of the clearing system(s).
    /// </summary>
    [IsoId("_QMJplZJKEeuAlLVx8pyt3w")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public Organisation38? Depository { get; init; }

    /// <summary>
    /// Entity(ies), asset(s) or security(ies) on which the credit responsibility lies as identified in the documentation.
    /// </summary>
    [IsoId("_QMJpl5JKEeuAlLVx8pyt3w")]
    [DisplayName("Underlying Risk")]
    [IsoXmlTag("UndrlygRsk")]
    public Organisation38? UnderlyingRisk { get; init; }
}
