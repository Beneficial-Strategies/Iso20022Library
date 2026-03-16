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
[IsoId("_Q8Um4TnGEeWV5sr121Fc8A")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown28
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_Rag-tTnGEeWV5sr121Fc8A")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_Rag-vTnGEeWV5sr121Fc8A")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance7? LotQuantity { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_Rag-xTnGEeWV5sr121Fc8A")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_Rag-zTnGEeWV5sr121Fc8A")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price2? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_Rag-1TnGEeWV5sr121Fc8A")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [IsoId("_Rag-3TnGEeWV5sr121Fc8A")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_Rag-5TnGEeWV5sr121Fc8A")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_Rag-7TnGEeWV5sr121Fc8A")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; }
}
