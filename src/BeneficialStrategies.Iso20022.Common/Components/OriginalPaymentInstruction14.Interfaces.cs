// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction14 : IOriginalPaymentInstruction14
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction14.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInstruction14.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction59> IOriginalPaymentInstruction14.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
