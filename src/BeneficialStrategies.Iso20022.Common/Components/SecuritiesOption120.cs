// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_qa7QgatoEfCqjuqNaaNXgw")]
[DisplayName("Securities Option120")]
public record SecuritiesOption120
{
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    [IsoId("_qjWzx6toEfCqjuqNaaNXgw")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes130 SecurityDetails { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_qjWzz6toEfCqjuqNaaNXgw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_qjWz16toEfCqjuqNaaNXgw")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_qjWz36toEfCqjuqNaaNXgw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator5Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Specifies the nature of the securities issue.
    /// </summary>
    [IsoId("_qjWz56toEfCqjuqNaaNXgw")]
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_qjXa0atoEfCqjuqNaaNXgw")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    [IsoId("_qjXa2atoEfCqjuqNaaNXgw")]
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_qjXa26toEfCqjuqNaaNXgw")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_qjXa3atoEfCqjuqNaaNXgw")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity51Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_qjXa5atoEfCqjuqNaaNXgw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat41Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_qjXa7atoEfCqjuqNaaNXgw")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_qjXa76toEfCqjuqNaaNXgw")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which cash proceeds are to be credited/debited.
    /// </summary>
    [IsoId("_qjXa96toEfCqjuqNaaNXgw")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_qjXa_6toEfCqjuqNaaNXgw")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period12Choice_? TradingPeriod { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_qjXbB6toEfCqjuqNaaNXgw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate20 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_qjXbD6toEfCqjuqNaaNXgw")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate129? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_qjXbF6toEfCqjuqNaaNXgw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice82? PriceDetails { get; init; }

    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    [IsoId("_qjXbH6toEfCqjuqNaaNXgw")]
    [DisplayName("Price Basis")]
    [IsoXmlTag("PricBsis")]
    public DTCBaseDisbursed1Code? PriceBasis { get; init; }

    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    [IsoId("_qjXbJ6toEfCqjuqNaaNXgw")]
    [DisplayName("Estimated Price Indicator")]
    [IsoXmlTag("EstmtdPricInd")]
    public IsoYesNoIndicator? EstimatedPriceIndicator { get; init; }

    /// <summary>
    /// Decimal above which numbers are rounded. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_qjXbL6toEfCqjuqNaaNXgw")]
    [DisplayName("Rounding Factor")]
    [IsoXmlTag("RndgFctr")]
    public IsoDecimalNumber? RoundingFactor { get; init; }

    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    [IsoId("_qjXbN6toEfCqjuqNaaNXgw")]
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    public IsoYesNoIndicator? ChargeIndicator { get; init; }

    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    [IsoId("_qjXbP6toEfCqjuqNaaNXgw")]
    [DisplayName("Reinvestment Income Classification")]
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; }
}
