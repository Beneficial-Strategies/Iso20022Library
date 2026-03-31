// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Option114.
/// </summary>
[IsoId("_g2RysYV5Ee-oeNhl-Tk6YQ")]
[DisplayName("Securities Option114")]
public record SecuritiesOption114
{
    /// <summary>
    /// Charge Indicator.
    /// </summary>
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    public IsoYesNoIndicator? ChargeIndicator { get; init; }

    /// <summary>
    /// Country Of Income Source.
    /// </summary>
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Currency Option.
    /// </summary>
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate20 DateDetails { get; init; }

    /// <summary>
    /// Entitled Quantity.
    /// </summary>
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity51Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Estimated Price Indicator.
    /// </summary>
    [DisplayName("Estimated Price Indicator")]
    [IsoXmlTag("EstmtdPricInd")]
    public IsoYesNoIndicator? EstimatedPriceIndicator { get; init; }

    /// <summary>
    /// Exemption Type.
    /// </summary>
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Income Type.
    /// </summary>
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// New Securities Issuance Indicator.
    /// </summary>
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; }

    /// <summary>
    /// Non Eligible Proceeds Indicator.
    /// </summary>
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator5Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Other Income Type.
    /// </summary>
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Price Basis.
    /// </summary>
    [DisplayName("Price Basis")]
    [IsoXmlTag("PricBsis")]
    public DTCBaseDisbursed1Code? PriceBasis { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice82? PriceDetails { get; init; }

    /// <summary>
    /// Rate Details.
    /// </summary>
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate129? RateDetails { get; init; }

    /// <summary>
    /// Reinvestment Income Classification.
    /// </summary>
    [DisplayName("Reinvestment Income Classification")]
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; }

    /// <summary>
    /// Rounding Factor.
    /// </summary>
    [DisplayName("Rounding Factor")]
    [IsoXmlTag("RndgFctr")]
    public IsoDecimalNumber? RoundingFactor { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat41Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Security Details.
    /// </summary>
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes130 SecurityDetails { get; init; }

    /// <summary>
    /// Temporary Financial Instrument Indicator.
    /// </summary>
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Trading Period.
    /// </summary>
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period6Choice_? TradingPeriod { get; init; }
}
