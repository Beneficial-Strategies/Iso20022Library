// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the total sum of entries per bank transaction code.
/// </summary>
[IsoId("_RpY9tdp-Ed-ak6NoX_4Aeg_-609547730")]
[DisplayName("Totals Per Bank Transaction Code")]
public record TotalsPerBankTransactionCode2
{
    /// <summary>
    /// Number of individual entries for the bank transaction code.
    /// </summary>
    [IsoId("_RpY9ttp-Ed-ak6NoX_4Aeg_-609547699")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; }

    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_RpY9t9p-Ed-ak6NoX_4Aeg_-609547668")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; }

    /// <summary>
    /// Total amount that is the result of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_RpY9uNp-Ed-ak6NoX_4Aeg_-609547359")]
    [DisplayName("Total Net Entry Amount")]
    [IsoXmlTag("TtlNetNtryAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; }

    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_RpY9udp-Ed-ak6NoX_4Aeg_-609547336")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the bank transaction code is related to booked or forecast items.
    /// </summary>
    [IsoId("_RpiHoNp-Ed-ak6NoX_4Aeg_-577224009")]
    [DisplayName("Forecast Indicator")]
    [IsoXmlTag("FcstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ForecastIndicator { get; init; }

    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_RpiHodp-Ed-ak6NoX_4Aeg_-609547243")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; }

    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.
    /// </summary>
    [IsoId("_RpiHotp-Ed-ak6NoX_4Aeg_-609547181")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability2? Availability { get; init; }
}
