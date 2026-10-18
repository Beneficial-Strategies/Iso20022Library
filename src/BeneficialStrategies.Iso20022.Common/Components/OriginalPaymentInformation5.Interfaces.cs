// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInformation5 : IOriginalPaymentInformation5
{
    IEnumerable<IStatusReasonInformation9> IOriginalPaymentInformation5.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInformation5.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransactionInformation34> IOriginalPaymentInformation5.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
