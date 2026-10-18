// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction60 : IPaymentTransaction60
{
    IOriginalGroupInformation3? IPaymentTransaction60.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ICharges2> IPaymentTransaction60.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction60.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction60.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction60.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference22? IPaymentTransaction60.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction60.SupplementaryData => SupplementaryData;
}
