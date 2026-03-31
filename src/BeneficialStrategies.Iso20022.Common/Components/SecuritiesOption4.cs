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
[IsoId("_UGvw9dp-Ed-ak6NoX_4Aeg_-1725571368")]
[DisplayName("Securities Option")]
public record SecuritiesOption4
{
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    [IsoId("_UGvw9tp-Ed-ak6NoX_4Aeg_-1664491981")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public required FinancialInstrumentAttributes5 SecurityDetails { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_UGvw99p-Ed-ak6NoX_4Aeg_-1725571091")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_UGvw-Np-Ed-ak6NoX_4Aeg_-1725571073")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_UGvw-dp-Ed-ak6NoX_4Aeg_-397550341")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_UGvw-tp-Ed-ak6NoX_4Aeg_1287464264")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public Quantity6Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_UG464Np-Ed-ak6NoX_4Aeg_1783984237")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UG464dp-Ed-ak6NoX_4Aeg_-1725570978")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_UG464tp-Ed-ak6NoX_4Aeg_-1725570705")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_UG4649p-Ed-ak6NoX_4Aeg_-632326226")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period1Choice_? TradingPeriod { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_UG465Np-Ed-ak6NoX_4Aeg_-1725570454")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate2 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_UG465dp-Ed-ak6NoX_4Aeg_-1725570489")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate7? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_UG465tp-Ed-ak6NoX_4Aeg_-1725570584")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice10? PriceDetails { get; init; }
}
