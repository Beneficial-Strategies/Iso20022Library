// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction23 : IOriginalPaymentInstruction23
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction23.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction23.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction82> IOriginalPaymentInstruction23.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
