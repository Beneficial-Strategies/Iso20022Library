// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TrackerData7ValidatorTests
{
    private readonly TrackerData7Validator _sut = new();

    private static ITrackerData7 ValidMessage() =>
        IsoDataFactory.Make<ITrackerData7>(b => b
            .Set(x => x.ConfirmedAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.ConfirmedDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.TrackerRecord).To([
                IsoDataFactory.Make<ITrackerRecord5>(b2 => b2
                    .Set(x2 => x2.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))),
            ]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyTrackerRecord_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TrackerRecord).To([]));
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.TrackerRecord);
    }
}
