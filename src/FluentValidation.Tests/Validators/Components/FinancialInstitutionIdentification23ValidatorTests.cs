// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FinancialInstitutionIdentification23ValidatorTests
{
    private readonly FinancialInstitutionIdentification23Validator _sut = new();

    private static FinancialInstitutionIdentification23 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ClearingSystemMemberIdentification = new ClearingSystemMemberIdentification2
            {
                MemberIdentification = "MEMBER-001",
            },
            Other = new GenericFinancialIdentification1 { Identification = "ID-001" },
            PostalAddress = new PostalAddress27 { TownName = "Springfield" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
