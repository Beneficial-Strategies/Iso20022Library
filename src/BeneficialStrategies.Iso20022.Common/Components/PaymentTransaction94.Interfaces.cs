// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction94 : IPaymentTransaction94
{
    IOriginalGroupInformation29? IPaymentTransaction94.OriginalGroupInformation => OriginalGroupInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction94.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction94.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference27? IPaymentTransaction94.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction94.SupplementaryData => SupplementaryData;
}
