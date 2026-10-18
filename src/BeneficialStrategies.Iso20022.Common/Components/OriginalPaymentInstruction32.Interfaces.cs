// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction32 : IOriginalPaymentInstruction32
{
    IEnumerable<IStatusReasonInformation12> IOriginalPaymentInstruction32.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction32.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction105> IOriginalPaymentInstruction32.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
