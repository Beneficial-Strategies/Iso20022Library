// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction142 : IPaymentTransaction142
{
    IOriginalGroupInformation29? IPaymentTransaction142.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction142.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges12> IPaymentTransaction142.ChargesInformation => ChargesInformation;
    IDateAndDateTime2Choice? IPaymentTransaction142.ProcessingDate => ProcessingDate;
    IDateAndDateTime2Choice? IPaymentTransaction142.EffectiveInterbankSettlementDate => EffectiveInterbankSettlementDate;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction142.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction142.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference35? IPaymentTransaction142.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction142.SupplementaryData => SupplementaryData;
}
