// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction91 : IPaymentTransaction91
{
    IOriginalGroupInformation29? IPaymentTransaction91.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IStatusReasonInformation11> IPaymentTransaction91.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction91.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction91.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction91.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference27? IPaymentTransaction91.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction91.SupplementaryData => SupplementaryData;
}
