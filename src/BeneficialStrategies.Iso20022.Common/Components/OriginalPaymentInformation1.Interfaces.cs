// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInformation1 : IOriginalPaymentInformation1
{
    IEnumerable<IStatusReasonInformation8> IOriginalPaymentInformation1.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<INumberOfTransactionsPerStatus3> IOriginalPaymentInformation1.NumberOfTransactionsPerStatus => NumberOfTransactionsPerStatus;
    IEnumerable<IPaymentTransactionInformation25> IOriginalPaymentInformation1.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
