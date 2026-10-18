// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV12 : ICustomerDirectDebitInitiationV12
{
    IGroupHeader118 ICustomerDirectDebitInitiationV12.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction50> ICustomerDirectDebitInitiationV12.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICustomerDirectDebitInitiationV12.SupplementaryData => SupplementaryData;
}
