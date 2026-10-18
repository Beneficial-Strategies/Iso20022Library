// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInformation2 : IOriginalPaymentInformation2
{
    IEnumerable<IReversalReasonInformation6> IOriginalPaymentInformation2.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransactionInformation28> IOriginalPaymentInformation2.TransactionInformation => TransactionInformation;
}
