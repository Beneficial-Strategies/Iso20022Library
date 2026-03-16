// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_nioe4Sp6EeyR9JrVGfaMKw")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown58
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_n54hQSp6EeyR9JrVGfaMKw")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_n54hSSp6EeyR9JrVGfaMKw")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance16? LotQuantity { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_n54hUSp6EeyR9JrVGfaMKw")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTime2Choice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_n54hWSp6EeyR9JrVGfaMKw")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price7? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_n54hYSp6EeyR9JrVGfaMKw")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [IsoId("_n54haSp6EeyR9JrVGfaMKw")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_n54hcSp6EeyR9JrVGfaMKw")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in a currency  other than the base currency of the account.
    /// </summary>
    [IsoId("_n54heSp6EeyR9JrVGfaMKw")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; }
}
