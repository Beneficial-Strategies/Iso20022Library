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
[IsoId("_TnS2cfo0EeCfbIXrKCjG0g")]
[DisplayName("Securities Option")]
public record SecuritiesOption25
{
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    [IsoId("_TnS2e_o0EeCfbIXrKCjG0g")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes34 SecurityDetails { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_TnS2hfo0EeCfbIXrKCjG0g")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_TnS2j_o0EeCfbIXrKCjG0g")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_TnS2mfo0EeCfbIXrKCjG0g")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_UVfZMPo0EeCfbIXrKCjG0g")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_TnS2o_o0EeCfbIXrKCjG0g")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity6Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_TnS2rfo0EeCfbIXrKCjG0g")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_TnS2t_o0EeCfbIXrKCjG0g")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_TnS2wfo0EeCfbIXrKCjG0g")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period3Choice_? TradingPeriod { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_TnS2y_o0EeCfbIXrKCjG0g")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate5 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_TnS21fo0EeCfbIXrKCjG0g")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate28? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_TnS23_o0EeCfbIXrKCjG0g")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice31? PriceDetails { get; init; }
}
