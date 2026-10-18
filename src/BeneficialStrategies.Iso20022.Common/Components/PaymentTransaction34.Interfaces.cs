// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction34 : IPaymentTransaction34
{
    IOriginalGroupInformation3? IPaymentTransaction34.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ICharges2> IPaymentTransaction34.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction34.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction34.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReturnReason1> IPaymentTransaction34.ReturnReasonInformation => ReturnReasonInformation;
    IOriginalTransactionReference16? IPaymentTransaction34.OriginalTransactionReference => OriginalTransactionReference;
}
