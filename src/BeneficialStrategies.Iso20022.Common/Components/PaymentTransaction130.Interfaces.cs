// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction130 : IPaymentTransaction130
{
    IOriginalGroupInformation29? IPaymentTransaction130.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction130.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges7> IPaymentTransaction130.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction130.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction130.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction130.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference35? IPaymentTransaction130.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction130.SupplementaryData => SupplementaryData;
}
