// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction110 : IPaymentTransaction110
{
    IOriginalGroupInformation29? IPaymentTransaction110.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction110.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges7> IPaymentTransaction110.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction110.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction110.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction110.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference28? IPaymentTransaction110.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction110.SupplementaryData => SupplementaryData;
}
