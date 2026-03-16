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
[IsoId("_ort8QQ01EeK9as54HthO0w")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown24
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_pCgrqQ01EeK9as54HthO0w")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_pCgrsw01EeK9as54HthO0w")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance4? LotQuantity { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_pCgrvQ01EeK9as54HthO0w")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_pCgrxw01EeK9as54HthO0w")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price2? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_pCgr0Q01EeK9as54HthO0w")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [IsoId("_pCgr2w01EeK9as54HthO0w")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_pCgr5Q01EeK9as54HthO0w")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_pCgr7w01EeK9as54HthO0w")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; }
}
