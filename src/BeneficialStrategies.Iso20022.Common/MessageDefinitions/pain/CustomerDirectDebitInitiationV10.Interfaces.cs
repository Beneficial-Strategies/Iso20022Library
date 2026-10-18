// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV10 : ICustomerDirectDebitInitiationV10
{
    IGroupHeader83 ICustomerDirectDebitInitiationV10.GroupHeader => GroupHeader;
    IPaymentInstruction39 ICustomerDirectDebitInitiationV10.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV10.SupplementaryData => SupplementaryData;
}
