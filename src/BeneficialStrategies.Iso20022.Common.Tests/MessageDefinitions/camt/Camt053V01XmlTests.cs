// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : ~/Downloads/archive_banktocustomer_cash_management_1_73a757db02/camt.053.001.01.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Codesets;
using BalCode = BeneficialStrategies.Iso20022.Choices.BalanceType2Choice.Code;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="BankToCustomerStatementV01"/>
/// (camt.053.001.01 — Bank to Customer Statement V01).
///
/// Verifies that a minimal end-of-day statement with two balances
/// (opening and closing booked) deserializes correctly and survives a round-trip.
/// </summary>
public class Camt053V01XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.053.001.01_sample.xml";

    private const string ExpectedMsgId = "DEUTDEFF/240315/CAM053/00001";
    private const string ExpectedMsgRcptName = "Acme Manufacturing GmbH";
    private const string ExpectedStmtId = "DEUTDEFF-ACME-STMT-20240315-001";
    private const decimal ExpectedOpeningBalance = 905_500.00m;
    private const decimal ExpectedClosingBalance = 952_750.00m;

    private static XDocument LoadEmbeddedXml()
    {
        var asm = Assembly.GetExecutingAssembly();
        using var stream =
            asm.GetManifestResourceStream(ResourceName)
            ?? throw new InvalidOperationException(
                $"Embedded resource '{ResourceName}' not found. "
                    + $"Available: {string.Join(", ", asm.GetManifestResourceNames())}"
            );
        return XDocument.Load(stream);
    }

    [Fact]
    public void Deserialize_GroupHeader_HasCorrectMsgId()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV01>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.NotNull(result.GroupHeader.MessageRecipient);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient!.Name);
    }

    [Fact]
    public void Deserialize_Statement_TwoBalances_OpeningAndClosing()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV01>(
            LoadEmbeddedXml()
        );

        var stmt = result.Statement;
        Assert.Equal(ExpectedStmtId, stmt.Identification);
        Assert.Equal(2, stmt.Balance.Count);

        var bal1 = stmt.Balance[0];
        var balCode1 = Assert.IsType<BalCode>(bal1.Type);
        Assert.Equal(BalanceType9Code.OpeningBooked, balCode1.Value);
        Assert.Equal("EUR", bal1.Amount.Currency);
        Assert.Equal(ExpectedOpeningBalance, bal1.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal1.CreditDebitIndicator);

        var bal2 = stmt.Balance[1];
        var balCode2 = Assert.IsType<BalCode>(bal2.Type);
        Assert.Equal(BalanceType9Code.ClosingBooked, balCode2.Value);
        Assert.Equal("EUR", bal2.Amount.Currency);
        Assert.Equal(ExpectedClosingBalance, bal2.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal2.CreditDebitIndicator);
    }

    [Fact]
    public void RoundTrip_BalancesAndHeader_Survive()
    {
        var original = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV01>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV01>(xml);

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient?.Name);
        Assert.Equal(2, result.Statement.Balance.Count);
        Assert.Equal(ExpectedOpeningBalance, result.Statement.Balance[0].Amount.Amount);
        Assert.Equal(ExpectedClosingBalance, result.Statement.Balance[1].Amount.Amount);
    }
}
