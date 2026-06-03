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
[IsoId("_zZzSYaucEfCqjuqNaaNXgw")]
[DisplayName("Securities Option122")]
public record SecuritiesOption122
{
    [IsoId("_ziQq2aucEfCqjuqNaaNXgw")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes129 SecurityDetails { get; init; }

    [IsoId("_ziQq4aucEfCqjuqNaaNXgw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    [IsoId("_ziQq6aucEfCqjuqNaaNXgw")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator3Choice? TemporaryFinancialInstrumentIndicator { get; init; }

    [IsoId("_ziQq8aucEfCqjuqNaaNXgw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator5Choice? NonEligibleProceedsIndicator { get; init; }

    [IsoId("_ziQq-aucEfCqjuqNaaNXgw")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator2Choice? IssuerOfferorTaxabilityIndicator { get; init; }

    [IsoId("_ziQq-6ucEfCqjuqNaaNXgw")]
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; }

    [IsoId("_ziQq_aucEfCqjuqNaaNXgw")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    [IsoId("_ziQrBaucEfCqjuqNaaNXgw")]
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    [IsoId("_ziQrB6ucEfCqjuqNaaNXgw")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    [IsoId("_ziQrCaucEfCqjuqNaaNXgw")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity51Choice? EntitledQuantity { get; init; }

    [IsoId("_ziQrEaucEfCqjuqNaaNXgw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat41Choice? SafekeepingPlace { get; init; }

    [IsoId("_ziQrGaucEfCqjuqNaaNXgw")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    [IsoId("_ziQrG6ucEfCqjuqNaaNXgw")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice? FractionDisposition { get; init; }

    [IsoId("_ziQrI6ucEfCqjuqNaaNXgw")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    [IsoId("_ziQrK6ucEfCqjuqNaaNXgw")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period12Choice? TradingPeriod { get; init; }

    [IsoId("_ziQrM6ucEfCqjuqNaaNXgw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate20 DateDetails { get; init; }

    [IsoId("_ziQrO6ucEfCqjuqNaaNXgw")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate123? RateDetails { get; init; }

    [IsoId("_ziQrQ6ucEfCqjuqNaaNXgw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice82? PriceDetails { get; init; }

    [IsoId("_ziQrS6ucEfCqjuqNaaNXgw")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts60? AmountDetails { get; init; }
}
