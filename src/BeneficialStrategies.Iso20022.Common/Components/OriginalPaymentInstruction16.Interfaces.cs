// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction16 : IOriginalPaymentInstruction16
{
    IEnumerable<IPaymentReversalReason7> IOriginalPaymentInstruction16.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction64> IOriginalPaymentInstruction16.TransactionInformation => TransactionInformation;
}
