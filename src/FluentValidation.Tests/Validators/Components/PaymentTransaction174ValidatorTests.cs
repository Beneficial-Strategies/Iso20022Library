// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction174ValidatorTests
{
    private readonly PaymentTransaction174Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentTransaction174>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction174>(b => b
            .Set(x => x.ReversalIdentification).To("RVSL-001")
            .Set(x => x.OriginalInstructionIdentification).To("INSTR-001")
            .Set(x => x.OriginalEndToEndIdentification).To("E2E-001")
            .Set(x => x.OriginalUETR).To("3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1")
            .Set(x => x.OriginalInstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.ReversedInstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>()])
            .Set(x => x.OriginalTransactionReference).To(IsoDataFactory.Make<IOriginalTransactionReference47>())
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
