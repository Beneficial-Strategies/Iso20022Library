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
[IsoId("_D34tONSzEeWG96DaYzntbg")]
[DisplayName("Statistics Transparency")]
public record StatisticsTransparency2
{
    /// <summary>
    /// Total number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_D35UQ9SzEeWG96DaYzntbg")]
    [DisplayName("Total Number Of Transactions Executed")]
    [IsoXmlTag("TtlNbOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberOfTransactionsExecuted { get; init; }

    /// <summary>
    /// Total volume of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_D35URdSzEeWG96DaYzntbg")]
    [DisplayName("Total Volume Of Transactions Executed")]
    [IsoXmlTag("TtlVolOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber TotalVolumeOfTransactionsExecuted { get; init; }
}
