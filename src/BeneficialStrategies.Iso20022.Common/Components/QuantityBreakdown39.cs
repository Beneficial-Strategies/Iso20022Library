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
[IsoId("_5W4BE5NLEeWGlc8L7oPDIg")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown39
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_5W4noZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification39? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_5W4nqZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance11? LotQuantity { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_5W4nsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_5W4nuZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price3? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_5W4nwZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [IsoId("_5W4nyZNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts6? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_5W4n0ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts6? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_5W4n2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts6? AlternateReportingCurrencyAmounts { get; init; }
}
