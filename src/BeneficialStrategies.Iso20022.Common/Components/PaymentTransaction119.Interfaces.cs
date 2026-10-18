// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction119 : IPaymentTransaction119
{
    IOriginalGroupInformation29? IPaymentTransaction119.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction119.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges7> IPaymentTransaction119.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction119.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction119.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction119.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference31? IPaymentTransaction119.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction119.SupplementaryData => SupplementaryData;
}
