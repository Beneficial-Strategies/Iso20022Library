// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV04 : ICustomerDirectDebitInitiationV04
{
    IGroupHeader55 ICustomerDirectDebitInitiationV04.GroupHeader => GroupHeader;
    IPaymentInstruction10 ICustomerDirectDebitInitiationV04.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV04.SupplementaryData => SupplementaryData;
}
