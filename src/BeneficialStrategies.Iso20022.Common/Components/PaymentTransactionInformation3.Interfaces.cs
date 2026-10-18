// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation3 : IPaymentTransactionInformation3
{
    IBranchAndFinancialInstitutionIdentification3? IPaymentTransactionInformation3.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IPaymentTransactionInformation3.InstructedAgent => InstructedAgent;
    IEnumerable<ICancellationReasonInformation1> IPaymentTransactionInformation3.CancellationReasonInformation => CancellationReasonInformation;
    IOriginalTransactionReference1? IPaymentTransactionInformation3.OriginalTransactionReference => OriginalTransactionReference;
}
