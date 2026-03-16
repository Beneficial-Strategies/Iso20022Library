// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistics for a financial instrument generated as part of transparency calculations.
/// </summary>
[IsoId("_L1E_AXvwEeanCNPcMT7sSg")]
[DisplayName("Statistics Transparency")]
public record StatisticsTransparency3
{
    /// <summary>
    /// Average Daily Turnover for the instrument in Euros.
    /// </summary>
    [IsoId("_L-xGgXvwEeanCNPcMT7sSg")]
    [DisplayName("Average Daily Turnover")]
    [IsoXmlTag("AvrgDalyTrnvr")]
    public ActiveCurrencyAndAmount? AverageDailyTurnover { get; init; }

    /// <summary>
    /// Average value of the transactions for the instrument in Euro.
    /// </summary>
    [IsoId("_L-xGg3vwEeanCNPcMT7sSg")]
    [DisplayName("Average Transaction Value")]
    [IsoXmlTag("AvrgTxVal")]
    public ActiveCurrencyAndAmount? AverageTransactionValue { get; init; }

    /// <summary>
    /// Large in scale order in respect of a share, depositary receipt, certificate or other similar financial instrument shall be considered large in scale compared with normal market size if, on the basis of the average daily turnover for that financial instrument, the order is equal to or larger than the minimum size of orders set out in the local regulation.
    /// </summary>
    [IsoId("_L-xGhXvwEeanCNPcMT7sSg")]
    [DisplayName("Large In Scale")]
    [IsoXmlTag("LrgInScale")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? LargeInScale { get; init; }

    /// <summary>
    /// Standard market size for shares, depositary receipts, ETFs, certificates and other similar financial instruments for which there is a liquid market shall be determined on the basis of the average value of transactions for each financial instrument and in accordance with the local regulation.
    /// </summary>
    [IsoId("_L-xGh3vwEeanCNPcMT7sSg")]
    [DisplayName("Standard Market Size")]
    [IsoXmlTag("StdMktSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? StandardMarketSize { get; init; }

    /// <summary>
    /// Average daily number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGiXvwEeanCNPcMT7sSg")]
    [DisplayName("Average Daily Number Of Transactions")]
    [IsoXmlTag("AvrgDalyNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? AverageDailyNumberOfTransactions { get; init; }

    /// <summary>
    /// Total number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGi3vwEeanCNPcMT7sSg")]
    [DisplayName("Total Number Of Transactions Executed")]
    [IsoXmlTag("TtlNbOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNumberOfTransactionsExecuted { get; init; }

    /// <summary>
    /// Total volume of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_L-xGjXvwEeanCNPcMT7sSg")]
    [DisplayName("Total Volume Of Transactions Executed")]
    [IsoXmlTag("TtlVolOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalVolumeOfTransactionsExecuted { get; init; }

    /// <summary>
    /// The total number of trading days for which the data is provided.
    /// </summary>
    [IsoId("_L-xGj3vwEeanCNPcMT7sSg")]
    [DisplayName("Total Number Of Trading Days")]
    [IsoXmlTag("TtlNbOfTradgDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfTradingDays { get; init; }
}
