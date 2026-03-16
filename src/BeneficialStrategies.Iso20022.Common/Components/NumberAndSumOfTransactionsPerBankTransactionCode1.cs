// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the total sum of entries per bank transaction code.
/// </summary>
[IsoId("_RU-M49p-Ed-ak6NoX_4Aeg_-1159458700")]
[DisplayName("Number And Sum Of Transactions Per Bank Transaction Code")]
public record NumberAndSumOfTransactionsPerBankTransactionCode1
{
    /// <summary>
    /// Number of individual entries contained in the report.
    /// </summary>
    [IsoId("_RU-M5Np-Ed-ak6NoX_4Aeg_-1158538669")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; }

    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M5dp-Ed-ak6NoX_4Aeg_-1158538591")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; }

    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_RU-M5tp-Ed-ak6NoX_4Aeg_1319749819")]
    [DisplayName("Total Net Entry Amount")]
    [IsoXmlTag("TtlNetNtryAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; }

    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_RU-M59p-Ed-ak6NoX_4Aeg_-223720667")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_RU-M6Np-Ed-ak6NoX_4Aeg_434460822")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest.
    /// </summary>
    [IsoId("_RVH94Np-Ed-ak6NoX_4Aeg_1922475023")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability1? Availability { get; init; }
}
