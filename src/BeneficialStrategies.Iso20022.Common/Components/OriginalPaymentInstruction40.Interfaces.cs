// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction40 : IOriginalPaymentInstruction40
{
    IEnumerable<IStatusReasonInformation12> IOriginalPaymentInstruction40.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction40.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransaction129> IOriginalPaymentInstruction40.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
