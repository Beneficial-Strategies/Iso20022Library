// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Agent = BeneficialStrategies.Iso20022.Choices.Party40Choice.Agent;

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Tests for <see cref="FIToFIPaymentCancellationRequestV10Validator"/>.
/// Rules sourced from ISO 20022 MCP server on 2026-03-13 (camt.056.001.10).
/// </summary>
public class FIToFIPaymentCancellationRequestV10ValidatorTests
{
    private readonly FIToFIPaymentCancellationRequestV10Validator _sut = new();

    // ── Helpers ────────────────────────────────────────────────────────────────

    private static Agent MakeAgent(string bic) => new()
    {
        FinancialInstitutionIdentification = new FinancialInstitutionIdentification18
        {
            BICFI = bic,
        },
    };

    private static CaseAssignment5 ValidAssignment() => new()
    {
        Identification = "ASSIGN-001",
        Assigner = MakeAgent("DEUTDEFFXXX"),
        Assignee = MakeAgent("BNPAFRPPXXX"),
        CreationDateTime = new DateTime(2024, 3, 16, 9, 0, 0),
    };

    private static UnderlyingTransaction28 ValidUnderlying() => new()
    {
        TransactionInformation = new PaymentTransaction137
        {
            OriginalEndToEndIdentification = "E2E-001",
            OriginalUETR = "97ed4827-7b6f-4491-a06f-b548d5a7512d",
        },
    };

    private static FIToFIPaymentCancellationRequestV10 ValidMessage() => new()
    {
        Assignment = ValidAssignment(),
        Underlying = ValidUnderlying(),
    };

    // ── Happy path ─────────────────────────────────────────────────────────────

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_WithOptionalCase_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            Case = new Case5
            {
                Identification = "CASE-001",
                Creator = MakeAgent("DEUTDEFFXXX"),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_WithControlData_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ControlData = new ControlData1 { NumberOfTransactions = "1" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ValidMessage_GroupCancellation_NoValidationErrors()
    {
        var msg = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                OriginalGroupInformationAndCancellation = new OriginalGroupHeader15
                {
                    OriginalMessageIdentification = "ORIG-MSG-001",
                    OriginalMessageNameIdentification = "pacs.008.001.11",
                    GroupCancellation = "true",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Required building blocks ───────────────────────────────────────────────

    [Fact]
    public void MissingAssignment_HasValidationError()
    {
        // Records require `Assignment` at compile time; bypass via cast to trigger runtime validation
        var msg = ValidMessage() with { };
        // Use reflection to clear the required property for test
        var result = _sut.Validate(new FIToFIPaymentCancellationRequestV10
        {
            // Assignment intentionally omitted — required property, FluentValidation NotNull check
            Assignment = null!,
            Underlying = ValidUnderlying(),
        });
        Assert.Contains(result.Errors,
            e => e.PropertyName == "Assignment");
    }

    [Fact]
    public void MissingUnderlying_HasValidationError()
    {
        var result = _sut.Validate(new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            Underlying = null!,
        });
        Assert.Contains(result.Errors,
            e => e.PropertyName == "Underlying");
    }

    // ── CaseAssignment5: Identification ───────────────────────────────────────

    [Fact]
    public void Assignment_Identification_Empty_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with { Identification = "" },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.Assignment.Identification);
    }

    [Fact]
    public void Assignment_Identification_TooLong_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with { Identification = new string('A', 36) },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.Assignment.Identification);
    }

    [Fact]
    public void Assignment_Identification_MaxLength35_NoError()
    {
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with { Identification = new string('A', 35) },
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Assignment.Identification);
    }

    // ── CaseAssignment5: required party fields ────────────────────────────────

    [Fact]
    public void Assignment_NullAssigner_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with { Assigner = null! },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.Assignment.Assigner);
    }

    [Fact]
    public void Assignment_NullAssignee_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with { Assignee = null! },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.Assignment.Assignee);
    }

    // ── ControlData1: NumberOfTransactions pattern ────────────────────────────

    [Fact]
    public void ControlData_NumberOfTransactions_AlphaChars_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ControlData = new ControlData1 { NumberOfTransactions = "12X" },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.ControlData!.NumberOfTransactions);
    }

    [Fact]
    public void ControlData_NumberOfTransactions_TooManyDigits_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ControlData = new ControlData1 { NumberOfTransactions = "1234567890123456" }, // 16 digits
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(x => x.ControlData!.NumberOfTransactions);
    }

    [Fact]
    public void ControlData_NumberOfTransactions_Valid_NoError()
    {
        var msg = ValidMessage() with
        {
            ControlData = new ControlData1 { NumberOfTransactions = "999" },
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ControlData!.NumberOfTransactions);
    }

    // ── PaymentTransaction137: OriginalUETR pattern ───────────────────────────

    [Fact]
    public void TransactionInfo_InvalidUETR_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = new PaymentTransaction137
                {
                    OriginalUETR = "not-a-valid-uuid",
                },
            },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(
                x => x.Underlying.TransactionInformation!.OriginalUETR);
    }

    [Fact]
    public void TransactionInfo_ValidUETR_NoError()
    {
        var msg = ValidMessage() with
        {
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = new PaymentTransaction137
                {
                    OriginalUETR = "97ed4827-7b6f-4491-a06f-b548d5a7512d",
                },
            },
        };
        _sut.TestValidate(msg)
            .ShouldNotHaveValidationErrorFor(
                x => x.Underlying.TransactionInformation!.OriginalUETR);
    }

    // ── PaymentTransaction137: OriginalEndToEndIdentification length ──────────

    [Fact]
    public void TransactionInfo_EndToEndId_TooLong_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = new PaymentTransaction137
                {
                    OriginalEndToEndIdentification = new string('X', 36),
                },
            },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(
                x => x.Underlying.TransactionInformation!.OriginalEndToEndIdentification);
    }

    // ── UnderlyingTransaction28: empty underlying ─────────────────────────────

    [Fact]
    public void Underlying_BothChildrenNull_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Underlying = new UnderlyingTransaction28
            {
                OriginalGroupInformationAndCancellation = null,
                TransactionInformation = null,
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors,
            e => e.ErrorMessage.Contains("at least one"));
    }

    // ── Cross-field: MessageOrGroupCaseRule ───────────────────────────────────

    [Fact]
    public void CasePresentAtBothMessageAndTransactionLevel_HasValidationError()
    {
        var msg = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            Case = new Case5 { Identification = "CASE-MSG", Creator = MakeAgent("DEUTDEFFXXX") },
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = new PaymentTransaction137
                {
                    Case = new Case5 { Identification = "CASE-TXN", Creator = MakeAgent("DEUTDEFFXXX") },
                    OriginalEndToEndIdentification = "E2E-001",
                },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors,
            e => e.PropertyName == "MessageOrGroupCaseRule");
    }

    [Fact]
    public void CasePresentAtBothMessageAndGroupLevel_HasValidationError()
    {
        var msg = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            Case = new Case5 { Identification = "CASE-MSG", Creator = MakeAgent("DEUTDEFFXXX") },
            Underlying = new UnderlyingTransaction28
            {
                OriginalGroupInformationAndCancellation = new OriginalGroupHeader15
                {
                    OriginalMessageIdentification = "ORIG-001",
                    OriginalMessageNameIdentification = "pacs.008.001.11",
                    Case = new Case5 { Identification = "CASE-GRP", Creator = MakeAgent("DEUTDEFFXXX") },
                },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors,
            e => e.PropertyName == "MessageOrGroupCaseRule");
    }

    [Fact]
    public void CasePresentOnlyAtTransactionLevel_NoRuleViolation()
    {
        var msg = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            // No message-level Case
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = new PaymentTransaction137
                {
                    Case = new Case5 { Identification = "CASE-TXN", Creator = MakeAgent("DEUTDEFFXXX") },
                    OriginalEndToEndIdentification = "E2E-001",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor("MessageOrGroupCaseRule");
    }

    // ── OriginalGroupHeader15: required fields ────────────────────────────────

    [Fact]
    public void GroupHeader_MissingOriginalMessageId_HasValidationError()
    {
        var msg = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = ValidAssignment(),
            Underlying = new UnderlyingTransaction28
            {
                OriginalGroupInformationAndCancellation = new OriginalGroupHeader15
                {
                    OriginalMessageIdentification = "",  // violates required Max35Text
                    OriginalMessageNameIdentification = "pacs.008.001.11",
                },
            },
        };
        _sut.TestValidate(msg)
            .ShouldHaveValidationErrorFor(
                x => x.Underlying.OriginalGroupInformationAndCancellation!.OriginalMessageIdentification);
    }
}
