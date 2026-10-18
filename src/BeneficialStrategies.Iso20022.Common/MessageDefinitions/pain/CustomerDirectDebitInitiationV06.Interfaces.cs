// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV06 : ICustomerDirectDebitInitiationV06
{
    IGroupHeader55 ICustomerDirectDebitInitiationV06.GroupHeader => GroupHeader;
    IPaymentInstruction18 ICustomerDirectDebitInitiationV06.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV06.SupplementaryData => SupplementaryData;
}
