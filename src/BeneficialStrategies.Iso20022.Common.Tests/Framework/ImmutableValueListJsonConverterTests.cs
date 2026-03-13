// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice;
using BeneficialStrategies.Iso20022.camt;
using System.Text.Json;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Verifies that <see cref="ImmutableValueListConverterFactory"/> correctly serializes
/// and deserializes all three collection types (<see cref="ImmutableValueList{T}"/>,
/// <see cref="ValueList{T}"/>, <see cref="SimpleValueList{T}"/>) so that ISO 20022
/// message records can be used as MassTransit (or any STJ-based) message bodies.
/// </summary>
public class ImmutableValueListJsonConverterTests
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerOptions.Default)
    {
        Converters = { ImmutableValueListConverterFactory.Instance },
    };

    // ── ValueList<T> ──────────────────────────────────────────────────────────

    [Fact]
    public void ValueList_String_RoundTrips()
    {
        ValueList<string> original = ["alpha", "beta", "gamma"];

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<ValueList<string>>(json, Options);

        Assert.NotNull(result);
        Assert.IsType<ValueList<string>>(result);
        Assert.Equal(original, result);
    }

    [Fact]
    public void ValueList_Empty_SerializesAsEmptyArray()
    {
        ValueList<int> original = [];

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<ValueList<int>>(json, Options);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.Equal("[]", json);
    }

    [Fact]
    public void ValueList_Null_SerializesAsNull_And_DeserializesAsNull()
    {
        ValueList<string>? original = null;

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<ValueList<string>?>(json, Options);

        Assert.Null(result);
        Assert.Equal("null", json);
    }

    // ── SimpleValueList<T> ───────────────────────────────────────────────────

    [Fact]
    public void SimpleValueList_Int_RoundTrips()
    {
        SimpleValueList<int> original = [1, 2, 3];

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<SimpleValueList<int>>(json, Options);

        Assert.NotNull(result);
        Assert.IsType<SimpleValueList<int>>(result);
        Assert.Equal(original, result);
    }

    // ── ImmutableValueList<T> ────────────────────────────────────────────────

    [Fact]
    public void ImmutableValueList_Int_RoundTrips()
    {
        ImmutableValueList<int> original = [10, 20, 30];

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<ImmutableValueList<int>>(json, Options);

        Assert.NotNull(result);
        Assert.Equal(original, result);
    }

    // ── Structural equality preserved after round-trip ───────────────────────

    [Fact]
    public void StructuralEquality_IsPreservedAfterRoundTrip()
    {
        ValueList<string> a = ["x", "y"];
        var json = JsonSerializer.Serialize(a, Options);
        var b = JsonSerializer.Deserialize<ValueList<string>>(json, Options)!;

        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    // ── Realistic ISO 20022 component: AccountStatement12.Balance ────────────

    /// <summary>
    /// <see cref="AccountStatement12.Balance"/> is declared as
    /// <c>ValueList&lt;CashBalance8&gt;</c>, making it the primary representative
    /// of collection properties in the ISO 20022 message graph. Verifying it
    /// round-trips proves the converter works on a real message component.
    /// </summary>
    [Fact]
    public void AccountStatement12_Balance_ValueList_RoundTrips()
    {
        var original = new AccountStatement12
        {
            Identification = "STMT-001",
            Account = Camt053ExamplesTests.CreateStatementAccount(),
            Balance =
            [
                Camt053ExamplesTests.CreateClosingBookedBalance(905_500.00m, CreditDebitCode.Credit),
                Camt053ExamplesTests.CreateClosingBookedBalance(952_750.00m, CreditDebitCode.Credit),
            ],
        };

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<AccountStatement12>(json, Options);

        Assert.NotNull(result);
        Assert.Equal(2, result.Balance.Count);
        Assert.Equal(905_500.00m, result.Balance[0].Amount.Amount);
        Assert.Equal(952_750.00m, result.Balance[1].Amount.Amount);
    }

    // ── Full BankToCustomerStatementV11 round-trip ────────────────────────────

    /// <summary>
    /// Full message round-trip: <see cref="BankToCustomerStatementV11"/> (camt.053.001.11)
    /// contains nested <c>ValueList</c> collection properties and polymorphic
    /// <see cref="EntryStatus1Choice_"/> variants. This is the end-to-end proof
    /// that the message can be used as a MassTransit service bus message body.
    /// </summary>
    [Fact]
    public void BankToCustomerStatementV11_FullMessage_RoundTrips()
    {
        var original = new BankToCustomerStatementV11
        {
            GroupHeader = Camt053ExamplesTests.CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "DEUTDEFF-ACME-STMT-20240315-001",
                Account = Camt053ExamplesTests.CreateStatementAccount(),
                Balance =
                [
                    Camt053ExamplesTests.CreateClosingBookedBalance(905_500.00m, CreditDebitCode.Credit),
                    Camt053ExamplesTests.CreateClosingBookedBalance(952_750.00m, CreditDebitCode.Credit),
                ],
                Entry = Camt053ExamplesTests.CreateCreditEntry(
                    new Code { Value = ExternalEntryStatus1Code.Booked }),
            },
        };

        var json = JsonSerializer.Serialize(original, Options);
        var result = JsonSerializer.Deserialize<BankToCustomerStatementV11>(json, Options);

        Assert.NotNull(result);
        Assert.Equal(original.GroupHeader.MessageIdentification,
            result.GroupHeader.MessageIdentification);
        Assert.Equal(2, result.Statement.Balance.Count);
        Assert.Equal(905_500.00m, result.Statement.Balance[0].Amount.Amount);

        // Verify choice type round-tripped with correct concrete variant
        var status = Assert.IsType<Code>(result.Statement.Entry!.Status);
        Assert.Equal(ExternalEntryStatus1Code.Booked, status.Value);
    }
}
