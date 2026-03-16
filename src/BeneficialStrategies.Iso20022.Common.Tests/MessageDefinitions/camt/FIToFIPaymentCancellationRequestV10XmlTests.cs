// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-12
// Schema    : https://www.iso20022.org/sites/default/files/schemas/camt.056.001.10.xsd
// Note      : Amounts are excluded from the sample XML because the ISO XSD represents
//             monetary amounts as simpleContent with a Ccy XML attribute, whereas this
//             library's C# model represents Currency and Amount as child elements.
//             Round-trip coverage for amounts is tracked separately.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice;
using BeneficialStrategies.Iso20022.Choices.Party40Choice;
using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="FIToFIPaymentCancellationRequestV10"/>.
///
/// The sample file <c>TestData/camt.056.001.10_sample.xml</c> was validated against
/// the ISO 20022 XSD on 2026-03-12 (see file header for details).
/// Tests here verify deserialization from that canonical file and that a
/// deserialized record can be re-serialized and re-deserialized without data loss.
/// </summary>
public class FIToFIPaymentCancellationRequestV10XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.056.001.10_sample.xml";

    private const string ExpectedAssignmentId = "DEUTDEFF/240316/CAMT056/00001";
    private const string ExpectedCaseId = "CASE-DEUTDEFF-20240316-001";
    private const string ExpectedAssignerBic = "DEUTDEFFXXX";
    private const string ExpectedAssigneeBic = "BNPAFRPPXXX";
    private const string ExpectedEndToEndId = "E2E-ACME-GLOBALSUPPLY-20240315-001";
    private const string ExpectedUetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";

    // ── Helpers ────────────────────────────────────────────────────────────────

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

    // ── Deserialize from embedded resource ────────────────────────────────────

    [Fact]
    public void Deserialize_FromEmbeddedResource_Succeeds()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(doc);

        Assert.NotNull(result);

        // Assignment
        Assert.Equal(ExpectedAssignmentId, result.Assignment.Identification);
        var assigner = Assert.IsType<Agent>(result.Assignment.Assigner);
        Assert.Equal(ExpectedAssignerBic, assigner.FinancialInstitutionIdentification.BICFI);
        var assignee = Assert.IsType<Agent>(result.Assignment.Assignee);
        Assert.Equal(ExpectedAssigneeBic, assignee.FinancialInstitutionIdentification.BICFI);

        // Case
        Assert.NotNull(result.Case);
        Assert.Equal(ExpectedCaseId, result.Case!.Identification);

        // Underlying transaction
        var txn = result.Underlying.TransactionInformation;
        Assert.NotNull(txn);
        Assert.Equal(ExpectedAssignmentId, txn!.CancellationIdentification);
        Assert.Equal(ExpectedEndToEndId, txn.OriginalEndToEndIdentification);
        Assert.Equal(ExpectedUetr, txn.OriginalUETR);

        // Cancellation reason — Code variant (CUST)
        var reason = Assert.IsType<Code>(txn.CancellationReasonInformation!.Reason);
        Assert.Equal(ExternalCancellationReason1Code.RequestedByCustomer, reason.Value);
    }

    // ── Round-trip: deserialize → serialize → deserialize ─────────────────────

    [Fact]
    public void Serialize_RoundTrip_FromEmbeddedResource_PreservesKeyFields()
    {
        var doc = LoadEmbeddedXml();
        var original = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(doc);

        // Serialize to string (pretty-printed via XDocument.ToString default)
        var xml = Iso20022XmlSerializer.SerializeToString(original);
        Assert.False(string.IsNullOrWhiteSpace(xml));

        // Deserialize the re-serialized XML
        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentCancellationRequestV10>(xml);

        Assert.NotNull(result);

        Assert.Equal(ExpectedAssignmentId, result.Assignment.Identification);
        var assigner = Assert.IsType<Agent>(result.Assignment.Assigner);
        Assert.Equal(ExpectedAssignerBic, assigner.FinancialInstitutionIdentification.BICFI);
        var assignee = Assert.IsType<Agent>(result.Assignment.Assignee);
        Assert.Equal(ExpectedAssigneeBic, assignee.FinancialInstitutionIdentification.BICFI);

        Assert.NotNull(result.Case);
        Assert.Equal(ExpectedCaseId, result.Case!.Identification);

        var txn = result.Underlying.TransactionInformation;
        Assert.NotNull(txn);
        Assert.Equal(ExpectedAssignmentId, txn!.CancellationIdentification);
        Assert.Equal(ExpectedEndToEndId, txn.OriginalEndToEndIdentification);
        Assert.Equal(ExpectedUetr, txn.OriginalUETR);

        var reason = Assert.IsType<Code>(txn.CancellationReasonInformation!.Reason);
        Assert.Equal(ExternalCancellationReason1Code.RequestedByCustomer, reason.Value);
    }
}
