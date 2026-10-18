// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction1 : IOriginalPaymentInstruction1
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction1.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInstruction1.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction32> IOriginalPaymentInstruction1.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
