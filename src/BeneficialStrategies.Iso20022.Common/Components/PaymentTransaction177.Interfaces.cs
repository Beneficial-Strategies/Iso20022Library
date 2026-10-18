// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction177 : IPaymentTransaction177
{
    IOriginalGroupInformation33? IPaymentTransaction177.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction177.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges16> IPaymentTransaction177.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction177.ProcessingDate => ProcessingDate;
    IDateAndDateTime2Choice? IPaymentTransaction177.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction177.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction177.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference47? IPaymentTransaction177.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction177.SupplementaryData => SupplementaryData;
}
