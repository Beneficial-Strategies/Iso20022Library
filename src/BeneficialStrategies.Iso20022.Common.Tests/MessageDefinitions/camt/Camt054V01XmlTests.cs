// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : ~/Downloads/archive_banktocustomer_cash_management_1_73a757db02/camt.054.001.01.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.camt;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="BankToCustomerDebitCreditNotificationV01"/>
/// (camt.054.001.01 — Bank to Customer Debit/Credit Notification V01).
///
/// Verifies that a minimal credit notification for one account
/// deserializes correctly and survives a round-trip.
/// </summary>
public class Camt054V01XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.054.001.01_sample.xml";

    private const string ExpectedMsgId = "DEUTDEFF/240315/CAM054/00001";
    private const string ExpectedMsgRcptName = "Acme Manufacturing GmbH";
    private const string ExpectedNtfctnId = "DEUTDEFF-ACME-NTFCTN-20240315-001";

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
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV01>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.NotNull(result.GroupHeader.MessageRecipient);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient!.Name);
    }

    [Fact]
    public void Deserialize_Notification_HasCorrectId()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV01>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedNtfctnId, result.Notification.Identification);
    }

    [Fact]
    public void RoundTrip_HeaderAndNotification_Survive()
    {
        var original = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV01>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV01>(
            xml
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient?.Name);
        Assert.Equal(ExpectedNtfctnId, result.Notification.Identification);
    }
}
