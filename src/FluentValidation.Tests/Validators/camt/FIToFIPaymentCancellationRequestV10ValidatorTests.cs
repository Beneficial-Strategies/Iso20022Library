// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using IAgent= BeneficialStrategies.Iso20022.Choices.Party40Choice.IAgent;
using CxlReasonChoice = BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice;
using CxlReasonCode = BeneficialStrategies.Iso20022.Codesets.ExternalCancellationReason1Code;

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Tests for <see cref="FIToFIPaymentCancellationRequestV10Validator"/>.
/// Rules sourced from ISO 20022 MCP server on 2026-03-13 (camt.056.001.10).
/// </summary>
public class FIToFIPaymentCancellationRequestV10ValidatorTests
{
    private readonly FIToFIPaymentCancellationRequestV10Validator _sut = new();

    // ── Helpers ────────────────────────────────────────────────────────────────

    private static IAgent MakeAgent(string bic) =>
        IsoDataFactory.Make<Choices.Party40Choice.IAgent>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification18>(b2 => b2
                .Set(x2 => x2.BICFI).To(bic))));

    private static ICaseAssignment5 ValidAssignment() =>
        IsoDataFactory.Make<ICaseAssignment5>(b => b
            .Set(x => x.Identification).To("ASSIGN-001")
            .Set(x => x.Assigner).To(MakeAgent("DEUTDEFFXXX"))
            .Set(x => x.Assignee).To(MakeAgent("BNPAFRPPXXX"))
            .Set(x => x.CreationDateTime).To(new DateTime(2024, 3, 16, 9, 0, 0)));

    private static IUnderlyingTransaction28 ValidUnderlying() =>
        IsoDataFactory.Make<IUnderlyingTransaction28>(b => b
            .Set(x => x.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b2 => b2
                .Set(x2 => x2.OriginalEndToEndIdentification).To("E2E-001")
                .Set(x2 => x2.OriginalUETR).To("97ed4827-7b6f-4491-a06f-b548d5a7512d"))]));

    private static IPaymentCancellationReason5 ValidCancellationReason() =>
        IsoDataFactory.Make<IPaymentCancellationReason5>(b => b
            .Set(x => x.Reason).To(IsoDataFactory.Make<CxlReasonChoice.ICode>(b2 => b2
            .Set(x2 => x2.Value).To(CxlReasonCode.RequestedByCustomer))));

    private static IFIToFIPaymentCancellationRequestV10 ValidMessage() =>
        IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Underlying).To([ValidUnderlying()]));

    // ── Happy path ─────────────────────────────────────────────────────────────

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_WithOptionalCase_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Case).To(IsoDataFactory.Make<ICase5>(b2 => b2
                .Set(x2 => x2.Identification).To("CASE-001")
                .Set(x2 => x2.Creator).To(MakeAgent("DEUTDEFFXXX")))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_WithControlData_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ControlData).To(IsoDataFactory.Make<IControlData1>(b2 => b2
                .Set(x2 => x2.NumberOfTransactions).To("1"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_GroupCancellation_NoValidationErrors()
    {
        // GroupCancellationAndReasonRule: when GroupCancellation is true,
        // CancellationReasonInformation/Reason must be present.
        var msg = IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-MSG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("true")
                    .Set(x3 => x3.CancellationReasonInformation).To([ValidCancellationReason()]))))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Required building blocks ───────────────────────────────────────────────

    [Fact]
    public void MissingAssignment_HasValidationError()
    {
        // Records require `Assignment` at compile time; bypass via cast to trigger runtime validation
        var msg = ValidMessage();
        // Use reflection to clear the required property for test
        var result = _sut.Validate(
            IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
                .Set(x => x.Assignment).To(null!)
                .Set(x => x.Underlying).To([ValidUnderlying()]))
        );
        Assert.Contains(result.Errors, e => e.PropertyName == "Assignment");
    }

    [Fact]
    public void MissingUnderlying_HasValidationError()
    {
        var result = _sut.Validate(
            IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
                .Set(x => x.Assignment).To(ValidAssignment())
                .Set(x => x.Underlying).To(null!))
        );
        Assert.Contains(result.Errors, e => e.PropertyName == "Underlying");
    }

    // ── CaseAssignment5: Identification ───────────────────────────────────────

    [Fact]
    public void Assignment_Identification_Empty_ThrowsAtConstruction()
    {
        // Max35Text constructor rejects empty — never reaches the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.With(ValidAssignment(), b => b
                .Set(x => x.Identification).To("")));
    }

    [Fact]
    public void Assignment_Identification_TooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.With(ValidAssignment(), b => b
                .Set(x => x.Identification).To(new string('A', 36))));
    }

    [Fact]
    public void Assignment_Identification_MaxLength35_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Assignment).To(IsoDataFactory.With(ValidAssignment(), b2 => b2
                .Set(x2 => x2.Identification).To(new string('A', 35)))));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Assignment.Identification);
    }

    // ── CaseAssignment5: required party fields ────────────────────────────────

    [Fact]
    public void Assignment_NullAssigner_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Assignment).To(IsoDataFactory.With(ValidAssignment(), b2 => b2
            .Set(x2 => x2.Assigner).To(null!))));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Assignment.Assigner);
    }

    [Fact]
    public void Assignment_NullAssignee_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Assignment).To(IsoDataFactory.With(ValidAssignment(), b2 => b2
            .Set(x2 => x2.Assignee).To(null!))));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Assignment.Assignee);
    }

    // ── ControlData1: NumberOfTransactions pattern ────────────────────────────

    [Fact]
    public void ControlData_NumberOfTransactions_AlphaChars_ThrowsAtConstruction()
    {
        // Max15NumericText enforces [0-9]{1,15} — invalid values cannot reach the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IControlData1>(b => b
                .Set(x => x.NumberOfTransactions).To("12X")));
    }

    [Fact]
    public void ControlData_NumberOfTransactions_TooManyDigits_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IControlData1>(b => b
                .Set(x => x.NumberOfTransactions).To("1234567890123456"))); // 16 digits
    }

    [Fact]
    public void ControlData_NumberOfTransactions_Valid_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ControlData).To(IsoDataFactory.Make<IControlData1>(b2 => b2
                .Set(x2 => x2.NumberOfTransactions).To("999"))));
        _sut.TestValidate(msg)
            .ShouldNotHaveValidationErrorFor(x => x.ControlData!.NumberOfTransactions);
    }

    // ── PaymentTransaction137: OriginalUETR pattern ───────────────────────────

    [Fact]
    public void TransactionInfo_InvalidUETR_ThrowsAtConstruction()
    {
        // UUIDv4Identifier enforces RFC 4122 pattern — invalid values cannot reach the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IPaymentTransaction137>(b => b
                .Set(x => x.OriginalUETR).To("not-a-valid-uuid")));
    }

    [Fact]
    public void TransactionInfo_ValidUETR_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.OriginalUETR).To("97ed4827-7b6f-4491-a06f-b548d5a7512d"))]))]));
        var result2 = _sut.Validate(msg);
        Assert.DoesNotContain(result2.Errors, e => e.PropertyName.EndsWith(".OriginalUETR"));
    }

    // ── PaymentTransaction137: OriginalEndToEndIdentification length ──────────

    [Fact]
    public void TransactionInfo_EndToEndId_TooLong_ThrowsAtConstruction()
    {
        // Max35Text constructor rejects TooLong — never reaches the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IPaymentTransaction137>(b => b
                .Set(x => x.OriginalEndToEndIdentification).To(new string('X', 36))));
    }

    // ── UnderlyingTransaction28: empty underlying ─────────────────────────────

    [Fact]
    public void Underlying_BothChildrenNull_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(null))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.ErrorMessage.Contains("at least one"));
    }

    // ── Cross-field: MessageOrGroupCaseRule ───────────────────────────────────

    [Fact]
    public void CasePresentAtBothMessageAndTransactionLevel_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Case).To(IsoDataFactory.Make<ICase5>(b2 => b2
                .Set(x2 => x2.Identification).To("CASE-MSG")
                .Set(x2 => x2.Creator).To(MakeAgent("DEUTDEFFXXX"))))
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-TXN")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX"))))
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MessageOrGroupCaseRule");
    }

    [Fact]
    public void CasePresentAtBothMessageAndGroupLevel_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Case).To(IsoDataFactory.Make<ICase5>(b2 => b2
                .Set(x2 => x2.Identification).To("CASE-MSG")
                .Set(x2 => x2.Creator).To(MakeAgent("DEUTDEFFXXX"))))
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-GRP")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX")))))))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MessageOrGroupCaseRule");
    }

    [Fact]
    public void CasePresentOnlyAtTransactionLevel_NoRuleViolation()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentCancellationRequestV10>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-TXN")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX"))))
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor("MessageOrGroupCaseRule");
    }

    // ── OriginalGroupHeader15: required fields ────────────────────────────────

    [Fact]
    public void GroupHeader_MissingOriginalMessageId_ThrowsAtConstruction()
    {
        // Max35Text constructor rejects empty strings (TooShort) — never reaches the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IOriginalGroupHeader15>(b => b
                .Set(x => x.OriginalMessageIdentification).To("")
                .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.11")));
    }

    // ── UnderlyingTransaction28: GroupCancellationAndReasonRule ──────────────────

    [Fact]
    public void GroupCancellationTrue_NoReason_ViolatesGroupCancellationAndReasonRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("true"))))]));
        var result = _sut.Validate(msg);
        Assert.Contains(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationAndReasonRule")
        );
    }

    [Fact]
    public void GroupCancellationTrue_WithReason_SatisfiesGroupCancellationAndReasonRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("true")
                    .Set(x3 => x3.CancellationReasonInformation).To([ValidCancellationReason()]))))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationAndReasonRule")
        );
    }

    // ── UnderlyingTransaction28: GroupCancellationTrueAndTransactionInformationRule ─

    [Fact]
    public void GroupCancellationTrue_WithTransactionInfo_ViolatesRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("true")
                    .Set(x3 => x3.CancellationReasonInformation).To([ValidCancellationReason()])))
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.Contains(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationTrueAndTransactionInformationRule")
        );
    }

    // ── UnderlyingTransaction28: GroupCancellationFalseAndTransactionInformationRule

    [Fact]
    public void GroupCancellationFalse_NoTransactionInfo_ViolatesRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("false"))))]));
        var result = _sut.Validate(msg);
        Assert.Contains(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationFalseAndTransactionInformationRule")
        );
    }

    [Fact]
    public void GroupCancellationFalse_WithTransactionInfo_SatisfiesRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("false")))
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationFalseAndTransactionInformationRule")
        );
    }

    // ── UnderlyingTransaction28: GroupCancellationAndNumberOfTransactionsRule ────

    [Fact]
    public void GroupCancellationFalse_NumberOfTransactionsMismatch_ViolatesRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("false")
                    .Set(x3 => x3.NumberOfTransactions).To("5")))
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.Contains(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationAndNumberOfTransactionsRule")
        );
    }

    [Fact]
    public void GroupCancellationFalse_NumberOfTransactionsMatches_SatisfiesRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.GroupCancellation).To("false")
                    .Set(x3 => x3.NumberOfTransactions).To("1")))
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupCancellationAndNumberOfTransactionsRule")
        );
    }

    // ── UnderlyingTransaction28: GroupOrTransactionCaseRule ──────────────────────

    [Fact]
    public void BothGroupAndTransactionHaveCase_ViolatesGroupOrTransactionCaseRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.OriginalGroupInformationAndCancellation).To(IsoDataFactory.Make<IOriginalGroupHeader15>(b3 => b3
                    .Set(x3 => x3.OriginalMessageIdentification).To("ORIG-001")
                    .Set(x3 => x3.OriginalMessageNameIdentification).To("pacs.008.001.11")
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-GRP")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX"))))))
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-TXN")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX"))))
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.ErrorMessage.Contains("GroupOrTransactionCaseRule"));
    }

    [Fact]
    public void OnlyTransactionHasCase_SatisfiesGroupOrTransactionCaseRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Underlying).To([IsoDataFactory.Make<IUnderlyingTransaction28>(b2 => b2
                .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction137>(b3 => b3
                    .Set(x3 => x3.Case).To(IsoDataFactory.Make<ICase5>(b4 => b4
                        .Set(x4 => x4.Identification).To("CASE-TXN")
                        .Set(x4 => x4.Creator).To(MakeAgent("DEUTDEFFXXX"))))
                    .Set(x3 => x3.OriginalEndToEndIdentification).To("E2E-001"))]))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(
            result.Errors,
            e => e.ErrorMessage.Contains("GroupOrTransactionCaseRule")
        );
    }
}
