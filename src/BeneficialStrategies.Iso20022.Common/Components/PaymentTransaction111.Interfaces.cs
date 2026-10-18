// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction111 : IPaymentTransaction111
{
    IOriginalGroupInformation29? IPaymentTransaction111.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction111.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges7> IPaymentTransaction111.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction111.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction111.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction111.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference28? IPaymentTransaction111.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction111.SupplementaryData => SupplementaryData;
}
