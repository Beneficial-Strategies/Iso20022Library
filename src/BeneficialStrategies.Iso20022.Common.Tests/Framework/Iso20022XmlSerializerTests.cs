// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using CxlCode = BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice.Code;
using CxlProprietary = BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice.Proprietary;
using EntryCode = BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice.Code;
using EntryProprietary = BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice.Proprietary;
using BeneficialStrategies.Iso20022.Choices.Party40Choice;
using BeneficialStrategies.Iso20022.camt;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// End-to-end tests for <see cref="Iso20022XmlSerializer"/> covering:
/// <list type="bullet">
///   <item>Correct namespace on every element</item>
///   <item>Collection properties (<see cref="ValueList{T}"/>)</item>
///   <item>Simple choice types (single-property discriminator)</item>
///   <item>Complex choice types (class-level <c>[IsoXmlTag]</c> wrapper)</item>
///   <item>Full message round-trip: serialize → parse → assert</item>
/// </list>
/// </summary>
public class Iso20022XmlSerializerTests
{
    private const string Camt053Ns = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.11";
    private const string Camt056Ns = "urn:iso:std:iso:20022:tech:xsd:camt.056.001.10";

    // ── Namespace ──────────────────────────────────────────────────────────────

    [Fact]
    public void Serialize_RootElement_HasCorrectNamespace()
    {
        var message = MinimalStatement();

        var doc = Iso20022XmlSerializer.Serialize(message);

        Assert.Equal(Camt053Ns, doc.Root!.Name.NamespaceName);
    }

    [Fact]
    public void Serialize_AllElements_InheritRootNamespace()
    {
        var message = MinimalStatement();

        var doc = Iso20022XmlSerializer.Serialize(message);

        foreach (var el in doc.Descendants())
            Assert.Equal(Camt053Ns, el.Name.NamespaceName);
    }

    // ── Round-trip: ValueList collection ──────────────────────────────────────

    /// <summary>
    /// <see cref="AccountStatement12.Balance"/> is declared as
    /// <c>ValueList&lt;CashBalance8&gt;</c>.  Verifies two balances serialize to
    /// two sibling <c>&lt;Bal&gt;</c> elements and deserialize back with correct values.
    /// </summary>
    [Fact]
    public void RoundTrip_ValueListCollection_TwoBalances()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = Camt053ExamplesTests.CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "STMT-001",
                Account = Camt053ExamplesTests.CreateStatementAccount(),
                Balance =
                [
                    Camt053ExamplesTests.CreateClosingBookedBalance(905_500.00m, CreditDebitCode.Credit),
                    Camt053ExamplesTests.CreateClosingBookedBalance(952_750.00m, CreditDebitCode.Credit),
                ],
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(xml);

        Assert.Equal(2, result.Statement.Balance.Count);
        Assert.Equal(905_500.00m, result.Statement.Balance[0].Amount.Amount);
        Assert.Equal(952_750.00m, result.Statement.Balance[1].Amount.Amount);
    }

    // ── Round-trip: simple choice (single-property discriminator) ──────────────

    /// <summary>
    /// <see cref="EntryStatus1Choice_"/> with <see cref="Code"/> variant serializes as
    /// <c>&lt;Sts&gt;&lt;Cd&gt;BOOK&lt;/Cd&gt;&lt;/Sts&gt;</c> and deserializes to
    /// the correct concrete type.
    /// </summary>
    [Fact]
    public void RoundTrip_SimpleChoice_EntryStatus_CodeVariant()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = Camt053ExamplesTests.CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "STMT-002",
                Account = Camt053ExamplesTests.CreateStatementAccount(),
                Entry = Camt053ExamplesTests.CreateCreditEntry(
                    new EntryCode { Value = ExternalEntryStatus1Code.Booked }),
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(xml);

        var status = Assert.IsType<EntryCode>(result.Statement.Entry!.Status);
        Assert.Equal(ExternalEntryStatus1Code.Booked, status.Value);
    }

    [Fact]
    public void RoundTrip_SimpleChoice_EntryStatus_ProprietaryVariant()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = Camt053ExamplesTests.CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "STMT-003",
                Account = Camt053ExamplesTests.CreateStatementAccount(),
                Entry = Camt053ExamplesTests.CreateCreditEntry(
                    new EntryProprietary { Value = "BNPFR-PRE-BOOKED" }),
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(xml);

        var status = Assert.IsType<EntryProprietary>(result.Statement.Entry!.Status);
        Assert.Equal("BNPFR-PRE-BOOKED", status.Value);
    }

    // ── Round-trip: complex choice (class-level [IsoXmlTag] wrapper) ───────────

    /// <summary>
    /// <see cref="Party40Choice.Agent"/> is a complex variant with two properties.
    /// It carries <c>[IsoXmlTag("Agt")]</c> at the class level, which becomes the
    /// discriminating wrapper: <c>&lt;Assgnr&gt;&lt;Agt&gt;…&lt;/Agt&gt;&lt;/Assgnr&gt;</c>.
    /// </summary>
    [Fact]
    public void RoundTrip_ComplexChoice_Party40_AgentVariant()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = Camt056ExamplesTests.CreateCaseAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = Camt056ExamplesTests.CreateTransactionCancellation(),
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(xml);

        Assert.IsType<Agent>(result.Assignment.Assigner);
        Assert.IsType<Agent>(result.Assignment.Assignee);
    }

    /// <summary>
    /// Verifies the <c>&lt;Agt&gt;</c> wrapper element IS present in the serialized XML,
    /// confirming XSD-compliant output (not a flat serialization).
    /// </summary>
    [Fact]
    public void Serialize_ComplexChoice_Party40Agent_ProducesAgtWrapperElement()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = Camt056ExamplesTests.CreateCaseAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = Camt056ExamplesTests.CreateTransactionCancellation(),
            },
        };

        var doc = Iso20022XmlSerializer.Serialize(message);
        var ns = XNamespace.Get(Camt056Ns);

        var agtElements = doc.Descendants(ns + "Agt").ToList();
        Assert.NotEmpty(agtElements);
    }

    // ── Round-trip: CancellationReason choice (camt.056) ──────────────────────

    [Fact]
    public void RoundTrip_CancellationReason_CodeVariant()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = Camt056ExamplesTests.CreateCaseAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = Camt056ExamplesTests.CreateTransactionCancellation(
                    new CxlCode { Value = ExternalCancellationReason1Code.RequestedByCustomer }),
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(xml);

        var reason = Assert.IsType<CxlCode>(
            result.Underlying.TransactionInformation!.CancellationReasonInformation!.Reason);
        Assert.Equal(ExternalCancellationReason1Code.RequestedByCustomer, reason.Value);
    }

    [Fact]
    public void RoundTrip_CancellationReason_ProprietaryVariant()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = Camt056ExamplesTests.CreateCaseAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = Camt056ExamplesTests.CreateTransactionCancellation(
                    new CxlProprietary { Value = "DEUTDE-FRAUD-HOLD" }),
            },
        };

        var xml = Iso20022XmlSerializer.SerializeToString(message);
        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(xml);

        var reason = Assert.IsType<CxlProprietary>(
            result.Underlying.TransactionInformation!.CancellationReasonInformation!.Reason);
        Assert.Equal("DEUTDE-FRAUD-HOLD", reason.Value);
    }

    // ── JSON options singleton ─────────────────────────────────────────────────

    [Fact]
    public void JsonSerializerOptions_Default_RoundTripsMessage()
    {
        var original = MinimalStatement();
        var opts = Iso20022JsonSerializerOptions.Default;

        var json = System.Text.Json.JsonSerializer.Serialize(original, opts);
        var result = System.Text.Json.JsonSerializer.Deserialize<BankToCustomerStatementV11>(json, opts);

        Assert.NotNull(result);
        Assert.Equal(original.GroupHeader.MessageIdentification,
            result.GroupHeader.MessageIdentification);
    }

    [Fact]
    public void JsonSerializerOptions_Default_IsReadOnly()
    {
        Assert.True(Iso20022JsonSerializerOptions.Default.IsReadOnly);
    }

    // ── Helpers ────────────────────────────────────────────────────────────────

    private static BankToCustomerStatementV11 MinimalStatement() => new()
    {
        GroupHeader = Camt053ExamplesTests.CreateGroupHeader(),
        Statement = new AccountStatement12
        {
            Identification = "STMT-MINIMAL",
            Account = Camt053ExamplesTests.CreateStatementAccount(),
        },
    };
}
