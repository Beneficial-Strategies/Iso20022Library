// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction47 : IOriginalPaymentInstruction47
{
    IEnumerable<INumberOfTransactionsPerStatus5> IOriginalPaymentInstruction47.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IStatusReasonInformation14> IOriginalPaymentInstruction47.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<IPaymentTransaction150> IOriginalPaymentInstruction47.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
