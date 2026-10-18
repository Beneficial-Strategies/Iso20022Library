// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV07 : ICustomerDirectDebitInitiationV07
{
    IGroupHeader55 ICustomerDirectDebitInitiationV07.GroupHeader => GroupHeader;
    IPaymentInstruction21 ICustomerDirectDebitInitiationV07.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV07.SupplementaryData => SupplementaryData;
}
