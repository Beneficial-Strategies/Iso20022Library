// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction31 : IOriginalPaymentInstruction31
{
    IEnumerable<IStatusReasonInformation12> IOriginalPaymentInstruction31.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction31.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction104> IOriginalPaymentInstruction31.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
