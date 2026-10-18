// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction27 : IOriginalPaymentInstruction27
{
    IEnumerable<IStatusReasonInformation11> IOriginalPaymentInstruction27.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction27.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction92> IOriginalPaymentInstruction27.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
