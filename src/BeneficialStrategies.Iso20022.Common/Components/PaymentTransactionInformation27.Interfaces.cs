// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation27 : IPaymentTransactionInformation27
{
    IOriginalGroupInformation3? IPaymentTransactionInformation27.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IChargesInformation5> IPaymentTransactionInformation27.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification4? IPaymentTransactionInformation27.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification4? IPaymentTransactionInformation27.InstructedAgent => InstructedAgent;
    IEnumerable<IReturnReasonInformation9> IPaymentTransactionInformation27.ReturnReasonInformation => ReturnReasonInformation;
    IOriginalTransactionReference13? IPaymentTransactionInformation27.OriginalTransactionReference => OriginalTransactionReference;
}
