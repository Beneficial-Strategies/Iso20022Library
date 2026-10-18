// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction161 : IPaymentTransaction161
{
    IEnumerable<ICharges16> IPaymentTransaction161.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction161.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction161.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction161.InstructingAgent => InstructingAgent;
    IOriginalGroupInformation29? IPaymentTransaction161.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalTransactionReference42? IPaymentTransaction161.OriginalTransactionReference => OriginalTransactionReference;
    IDateAndDateTime2Choice? IPaymentTransaction161.ProcessingDate => ProcessingDate;
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction161.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ISupplementaryData1> IPaymentTransaction161.SupplementaryData => SupplementaryData;
}
