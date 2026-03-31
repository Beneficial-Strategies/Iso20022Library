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
[IsoId("_ptKRrTi7Eeydid5dcNPKvg")]
[DisplayName("Securities Option")]
public record SecuritiesOption85
{
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    [IsoId("_ptKRuTi7Eeydid5dcNPKvg")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes115 SecurityDetails { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_ptKRwTi7Eeydid5dcNPKvg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_ptKRyTi7Eeydid5dcNPKvg")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator4Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_ptKR0Ti7Eeydid5dcNPKvg")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator4Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_ptKR2Ti7Eeydid5dcNPKvg")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Specifies the nature of the securities issue.
    /// </summary>
    [IsoId("_ptKR2zi7Eeydid5dcNPKvg")]
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_ptKR3Ti7Eeydid5dcNPKvg")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification47? IncomeType { get; init; }

    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    [IsoId("_ptKR5Ti7Eeydid5dcNPKvg")]
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification47> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_ptKR5zi7Eeydid5dcNPKvg")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification47> ExemptionType { get; init; } = [];

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_ptKR6Ti7Eeydid5dcNPKvg")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity54Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_ptKR8Ti7Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat39Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_ptKR-Ti7Eeydid5dcNPKvg")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_ptKR-zi7Eeydid5dcNPKvg")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType31Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_ptKSAzi7Eeydid5dcNPKvg")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_ptKSCzi7Eeydid5dcNPKvg")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period6Choice_? TradingPeriod { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_ptKSEzi7Eeydid5dcNPKvg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate18 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_ptKSGzi7Eeydid5dcNPKvg")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate95? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_ptKSIzi7Eeydid5dcNPKvg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice79? PriceDetails { get; init; }
}
