// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction5 : IOriginalPaymentInstruction5
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInstruction5.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInstruction5.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction41> IOriginalPaymentInstruction5.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
