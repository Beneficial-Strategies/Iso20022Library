// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction164 : IPaymentTransaction164
{
    IEnumerable<ICharges16> IPaymentTransaction164.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction164.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction164.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction164.InstructingAgent => InstructingAgent;
    IOriginalGroupInformation29? IPaymentTransaction164.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalTransactionReference42? IPaymentTransaction164.OriginalTransactionReference => OriginalTransactionReference;
    IDateAndDateTime2Choice? IPaymentTransaction164.ProcessingDate => ProcessingDate;
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction164.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ISupplementaryData1> IPaymentTransaction164.SupplementaryData => SupplementaryData;
}
