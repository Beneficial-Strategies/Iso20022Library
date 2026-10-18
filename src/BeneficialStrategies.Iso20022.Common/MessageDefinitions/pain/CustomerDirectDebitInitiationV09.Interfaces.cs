// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerDirectDebitInitiationV09 : ICustomerDirectDebitInitiationV09
{
    IGroupHeader83 ICustomerDirectDebitInitiationV09.GroupHeader => GroupHeader;
    IPaymentInstruction37 ICustomerDirectDebitInitiationV09.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerDirectDebitInitiationV09.SupplementaryData => SupplementaryData;
}
