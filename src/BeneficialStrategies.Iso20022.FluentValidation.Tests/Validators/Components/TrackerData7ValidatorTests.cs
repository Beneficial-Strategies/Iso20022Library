// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TrackerData7ValidatorTests
{
    private readonly TrackerData7Validator _sut = new();

    private static TrackerData7 ValidMessage() =>
        new()
        {
            ConfirmedAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            ConfirmedDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            TrackerRecord =
            [
                new TrackerRecord5
                {
                    Agent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                    },
                },
            ],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyTrackerRecord_HasValidationError()
    {
        var msg = ValidMessage() with { TrackerRecord = [] };
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.TrackerRecord);
    }
}
