// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies aggregated details on transactions within a defined numeric range bin.
/// </summary>
[IsoId("_mbY-AUD5EeW1yage4PQ__A")]
[DisplayName("Transactions Bin")]
public record TransactionsBin2
{
    /// <summary>
    /// Total number of transactions executed for that bin. Transactions that have been cancelled should be excluded from the reported figure.
    /// </summary>
    [IsoId("_mmgB00D5EeW1yage4PQ__A")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfTransactions { get; init; }

    /// <summary>
    /// Total notional amount traded represented by all transactions executed on the reporting day which size lies in the bin&apos;s range, expressed in the currency as specified in the local regulation (except for emission allowances and emission allowance derivatives: tons of carbon dioxide). Transactions that have been cancelled should be excluded from the reported figure.
    /// </summary>
    [IsoId("_mmgB1UD5EeW1yage4PQ__A")]
    [DisplayName("Total Notional Amount")]
    [IsoXmlTag("TtlNtnlAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber TotalNotionalAmount { get; init; }

    /// <summary>
    /// Specific range the quantitative data relates to. Only allowed ranges must be used.
    /// </summary>
    [IsoId("_mmgB10D5EeW1yage4PQ__A")]
    [DisplayName("Range")]
    [IsoXmlTag("Rg")]
    public required FromToQuantityRange2 Range { get; init; }
}
