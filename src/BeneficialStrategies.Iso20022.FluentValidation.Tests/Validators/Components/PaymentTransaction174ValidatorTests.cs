// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction174ValidatorTests
{
    private readonly PaymentTransaction174Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentTransaction174()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentTransaction174
        {
            ReversalIdentification = "RVSL-001",
            OriginalInstructionIdentification = "INSTR-001",
            OriginalEndToEndIdentification = "E2E-001",
            OriginalUETR = "3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1",
            OriginalInstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            ReversedInstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            ReversalReasonInformation = [new PaymentReversalReason10()],
            OriginalTransactionReference = new OriginalTransactionReference47(),
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
