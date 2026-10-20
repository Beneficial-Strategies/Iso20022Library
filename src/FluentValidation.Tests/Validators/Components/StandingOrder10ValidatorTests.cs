// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StandingOrder10ValidatorTests
{
    private readonly StandingOrder10Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IStandingOrder10>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var msg = IsoDataFactory.Make<IStandingOrder10>(b => b
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.Creditor).To(agent)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.Debtor).To(agent)
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.ExecutionType).To(IsoDataFactory.Make<Choices.ExecutionType1Choice.IEvent>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<Choices.EventType1Choice.IProprietary>(b3 => b3
                .Set(x3 => x3.Value).To("EVT")))))
            .Set(x => x.Frequency).To(Frequency2Code.Monthly)
            .Set(x => x.ValidityPeriod).To(IsoDataFactory.Make<Choices.DatePeriod2Choice.IFromDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.ZeroSweepIndicator).To(true));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
