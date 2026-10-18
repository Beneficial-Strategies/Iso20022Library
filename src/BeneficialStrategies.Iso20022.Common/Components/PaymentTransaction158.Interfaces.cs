// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction158 : IPaymentTransaction158
{
    IOriginalGroupInformation29? IPaymentTransaction158.OriginalGroupInformation => OriginalGroupInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction158.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction158.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference42? IPaymentTransaction158.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction158.SupplementaryData => SupplementaryData;
}
