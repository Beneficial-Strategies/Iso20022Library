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
    [IsoId("_qjWzx6toEfCqjuqNaaNXgw")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes130 SecurityDetails { get; init; }

    [IsoId("_qjWzz6toEfCqjuqNaaNXgw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    [IsoId("_qjWz16toEfCqjuqNaaNXgw")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator3Choice? TemporaryFinancialInstrumentIndicator { get; init; }

    [IsoId("_qjWz36toEfCqjuqNaaNXgw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator5Choice? NonEligibleProceedsIndicator { get; init; }

    [IsoId("_qjWz56toEfCqjuqNaaNXgw")]
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; }

    [IsoId("_qjXa0atoEfCqjuqNaaNXgw")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    [IsoId("_qjXa2atoEfCqjuqNaaNXgw")]
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    [IsoId("_qjXa26toEfCqjuqNaaNXgw")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    [IsoId("_qjXa3atoEfCqjuqNaaNXgw")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity51Choice? EntitledQuantity { get; init; }

    [IsoId("_qjXa5atoEfCqjuqNaaNXgw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat41Choice? SafekeepingPlace { get; init; }

    [IsoId("_qjXa7atoEfCqjuqNaaNXgw")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    [IsoId("_qjXa76toEfCqjuqNaaNXgw")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice? FractionDisposition { get; init; }

    [IsoId("_qjXa96toEfCqjuqNaaNXgw")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    [IsoId("_qjXa_6toEfCqjuqNaaNXgw")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period12Choice? TradingPeriod { get; init; }

    [IsoId("_qjXbB6toEfCqjuqNaaNXgw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate20 DateDetails { get; init; }

    [IsoId("_qjXbD6toEfCqjuqNaaNXgw")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate129? RateDetails { get; init; }

    [IsoId("_qjXbF6toEfCqjuqNaaNXgw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice82? PriceDetails { get; init; }

    [IsoId("_qjXbH6toEfCqjuqNaaNXgw")]
    [DisplayName("Price Basis")]
    [IsoXmlTag("PricBsis")]
    public DTCBaseDisbursed1Code? PriceBasis { get; init; }

    [IsoId("_qjXbJ6toEfCqjuqNaaNXgw")]
    [DisplayName("Estimated Price Indicator")]
    [IsoXmlTag("EstmtdPricInd")]
    public IsoYesNoIndicator? EstimatedPriceIndicator { get; init; }

    [IsoId("_qjXbL6toEfCqjuqNaaNXgw")]
    [DisplayName("Rounding Factor")]
    [IsoXmlTag("RndgFctr")]
    public IsoDecimalNumber? RoundingFactor { get; init; }

    [IsoId("_qjXbN6toEfCqjuqNaaNXgw")]
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    public IsoYesNoIndicator? ChargeIndicator { get; init; }

    [IsoId("_qjXbP6toEfCqjuqNaaNXgw")]
    [DisplayName("Reinvestment Income Classification")]
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; }
}
