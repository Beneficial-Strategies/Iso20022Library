// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV05 : ICustomerDirectDebitInitiationV05
{
    IGroupHeader55 ICustomerDirectDebitInitiationV05.GroupHeader => GroupHeader;
    IPaymentInstruction15 ICustomerDirectDebitInitiationV05.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV05.SupplementaryData => SupplementaryData;
}
