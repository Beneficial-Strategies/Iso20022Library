// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV11 : ICustomerDirectDebitInitiationV11
{
    IGroupHeader118 ICustomerDirectDebitInitiationV11.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction45> ICustomerDirectDebitInitiationV11.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICustomerDirectDebitInitiationV11.SupplementaryData => SupplementaryData;
}
