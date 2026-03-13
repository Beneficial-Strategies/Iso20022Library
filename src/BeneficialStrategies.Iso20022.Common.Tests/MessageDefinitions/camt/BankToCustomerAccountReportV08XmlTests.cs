// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-13
// Schema    : https://www.iso20022.org/sites/default/files/schemas/camt.052.001.08.xsd
//
// This file exercises the collection-of-collections structure fixed in GitHub Issue #1:
// BankToCustomerAccountReportV08.Report is ValueList<AccountReport25> and each
// AccountReport25 has ValueList<CashBalance8> Balance and ValueList<ReportEntry10> Entry.
//
// Scenario: single message with two Rpt elements (two bank accounts), demonstrating
// that deserialization correctly populates independent sub-collections per report.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using BalTypeCode = BeneficialStrategies.Iso20022.Choices.BalanceType10Choice.Code;
using DateChoice = BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date;
using EntryStatusCode = BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice.Code;
using IbanChoice = BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN;
using BeneficialStrategies.Iso20022.camt;
using System.Reflection;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="BankToCustomerAccountReportV08"/>
/// demonstrating the collection-of-collections pattern (Issue #1 regression guard).
///
/// The sample file covers two accounts in one message — each report carries its own
/// <see cref="AccountReport25.Balance"/> and <see cref="AccountReport25.Entry"/>
/// collections — proving that deserialization keeps the sub-collections independent.
///
/// XSD validated on 2026-03-13 against
/// https://www.iso20022.org/sites/default/files/schemas/camt.052.001.08.xsd
/// </summary>
public class BankToCustomerAccountReportV08XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.052.001.08_multi_report_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId      = "DEUTDEFF/240316/CAMT052/00001";
    private const string ExpectedRpt1Id     = "RPT-DEUTDEFF-20240316-001";
    private const string ExpectedRpt1Iban   = "DE89370400440532013000";
    private const string ExpectedRpt2Id     = "RPT-DEUTDEFF-20240316-002";
    private const string ExpectedRpt2Iban   = "DE75512108001245126199";

    // ── Helper ─────────────────────────────────────────────────────────────────

    private static XDocument LoadEmbeddedXml()
    {
        var asm = Assembly.GetExecutingAssembly();
        using var stream = asm.GetManifestResourceStream(ResourceName)
            ?? throw new InvalidOperationException(
                $"Embedded resource '{ResourceName}' not found. " +
                $"Available: {string.Join(", ", asm.GetManifestResourceNames())}");
        return XDocument.Load(stream);
    }

    // ── Deserialize ────────────────────────────────────────────────────────────

    /// <summary>
    /// Verifies that two <c>&lt;Rpt&gt;</c> elements in the XML deserialize to
    /// two independent <see cref="AccountReport25"/> instances in the
    /// <see cref="BankToCustomerAccountReportV08.Report"/> collection (Issue #1 guard).
    /// </summary>
    [Fact]
    public void Deserialize_TwoReports_BothPresent()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(
            LoadEmbeddedXml());

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(2, result.Report.Count);
        Assert.Equal(ExpectedRpt1Id, result.Report[0].Identification);
        Assert.Equal(ExpectedRpt2Id, result.Report[1].Identification);
    }

    /// <summary>
    /// Report 1 has two <c>&lt;Bal&gt;</c> elements; both must deserialize with
    /// correct amounts and balance-type codes (OPBD, ITBD).
    /// </summary>
    [Fact]
    public void Deserialize_Report1_TwoBalances_WithCorrectAmountsAndCodes()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(
            LoadEmbeddedXml());

        var rpt1 = result.Report[0];
        Assert.Equal(2, rpt1.Balance.Count);

        // Balance 1 — Opening Booked
        var bal1 = rpt1.Balance[0];
        var balCode1 = Assert.IsType<BalTypeCode>(bal1.Type.CodeOrProprietary);
        Assert.Equal(ExternalBalanceType1Code.OpeningBooked, balCode1.Value);
        Assert.Equal("EUR", bal1.Amount.Currency);
        Assert.Equal(500_000.00m, bal1.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal1.CreditDebitIndicator);

        // Balance 2 — Interim Booked
        var bal2 = rpt1.Balance[1];
        var balCode2 = Assert.IsType<BalTypeCode>(bal2.Type.CodeOrProprietary);
        Assert.Equal(ExternalBalanceType1Code.InterimBooked, balCode2.Value);
        Assert.Equal("EUR", bal2.Amount.Currency);
        Assert.Equal(547_250.00m, bal2.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal2.CreditDebitIndicator);
    }

    /// <summary>
    /// Report 1 has two <c>&lt;Ntry&gt;</c> elements; both must deserialize with
    /// correct amounts, credit/debit indicators, and BOOK status.
    /// </summary>
    [Fact]
    public void Deserialize_Report1_TwoEntries_WithCorrectAmountsAndStatus()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(
            LoadEmbeddedXml());

        var rpt1 = result.Report[0];
        Assert.Equal(2, rpt1.Entry.Count);

        var entry1 = rpt1.Entry[0];
        Assert.Equal("EUR", entry1.Amount.Currency);
        Assert.Equal(32_750.00m, entry1.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, entry1.CreditDebitIndicator);
        Assert.IsType<EntryStatusCode>(entry1.Status);

        var entry2 = rpt1.Entry[1];
        Assert.Equal("EUR", entry2.Amount.Currency);
        Assert.Equal(14_500.00m, entry2.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, entry2.CreditDebitIndicator);
    }

    /// <summary>
    /// Report 2 has one balance and one debit entry (payroll batch), independent
    /// of report 1's collections — this is the essence of the Issue #1 fix.
    /// </summary>
    [Fact]
    public void Deserialize_Report2_OneBalance_OneDebitEntry_IndependentOfReport1()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(
            LoadEmbeddedXml());

        var rpt2 = result.Report[1];

        // Account identity
        var iban = Assert.IsType<IbanChoice>(rpt2.Account.Identification);
        Assert.Equal(ExpectedRpt2Iban, iban.Value);

        // Balance
        var bal = Assert.Single(rpt2.Balance);
        Assert.Equal(125_000.00m, bal.Amount.Amount);
        Assert.Equal("EUR", bal.Amount.Currency);

        // Entry — payroll batch DBIT
        var entry = Assert.Single(rpt2.Entry);
        Assert.Equal(125_000.00m, entry.Amount.Amount);
        Assert.Equal(CreditDebitCode.Debit, entry.CreditDebitIndicator);
    }

    // ── Round-trip ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Deserialize → serialize → deserialize. Both reports and all sub-collections
    /// (balances, entries) must survive the round-trip with identical values.
    /// </summary>
    [Fact]
    public void RoundTrip_MultipleReports_AllCollectionsSurvive()
    {
        var original = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(
            LoadEmbeddedXml());

        var xml    = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerAccountReportV08>(xml);

        // Top-level structure
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(2, result.Report.Count);

        // Report 1 sub-collections
        Assert.Equal(2, result.Report[0].Balance.Count);
        Assert.Equal(2, result.Report[0].Entry.Count);
        Assert.Equal(500_000.00m, result.Report[0].Balance[0].Amount.Amount);
        Assert.Equal(547_250.00m, result.Report[0].Balance[1].Amount.Amount);
        Assert.Equal(32_750.00m,  result.Report[0].Entry[0].Amount.Amount);
        Assert.Equal(14_500.00m,  result.Report[0].Entry[1].Amount.Amount);

        // Report 2 sub-collections
        Assert.Single(result.Report[1].Balance);
        Assert.Single(result.Report[1].Entry);
        Assert.Equal(125_000.00m, result.Report[1].Balance[0].Amount.Amount);
        Assert.Equal(125_000.00m, result.Report[1].Entry[0].Amount.Amount);
        Assert.Equal(CreditDebitCode.Debit, result.Report[1].Entry[0].CreditDebitIndicator);
    }
}
