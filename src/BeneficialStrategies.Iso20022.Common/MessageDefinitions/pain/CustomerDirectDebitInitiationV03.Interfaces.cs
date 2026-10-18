// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV03 : ICustomerDirectDebitInitiationV03
{
    IGroupHeader55 ICustomerDirectDebitInitiationV03.GroupHeader => GroupHeader;
    IPaymentInstruction7 ICustomerDirectDebitInitiationV03.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV03.SupplementaryData => SupplementaryData;
}
