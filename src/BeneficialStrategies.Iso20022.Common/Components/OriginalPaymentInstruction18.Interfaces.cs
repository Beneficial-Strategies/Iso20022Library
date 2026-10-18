// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction18 : IOriginalPaymentInstruction18
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction18.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInstruction18.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction68> IOriginalPaymentInstruction18.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
