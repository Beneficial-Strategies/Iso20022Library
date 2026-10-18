// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction12 : IOriginalPaymentInstruction12
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction12.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInstruction12.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction57> IOriginalPaymentInstruction12.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
