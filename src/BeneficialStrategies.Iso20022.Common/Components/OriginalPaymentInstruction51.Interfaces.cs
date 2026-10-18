// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction51 : IOriginalPaymentInstruction51
{
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction51.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IStatusReasonInformation14> IOriginalPaymentInstruction51.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<IPaymentTransaction160> IOriginalPaymentInstruction51.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
