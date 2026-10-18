// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction73 : IPaymentTransaction73
{
    IOriginalGroupInformation3? IPaymentTransaction73.OriginalGroupInformation => OriginalGroupInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction73.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction73.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference24? IPaymentTransaction73.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction73.SupplementaryData => SupplementaryData;
}
