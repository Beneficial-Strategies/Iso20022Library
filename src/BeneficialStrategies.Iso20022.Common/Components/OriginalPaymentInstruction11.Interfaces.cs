// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction11 : IOriginalPaymentInstruction11
{
    IEnumerable<IPaymentReversalReason7> IOriginalPaymentInstruction11.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction56> IOriginalPaymentInstruction11.TransactionInformation => TransactionInformation;
}
