// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV04 : ICustomerCreditTransferInitiationV04
{
    IGroupHeader48 ICustomerCreditTransferInitiationV04.GroupHeader => GroupHeader;
    IPaymentInstruction6 ICustomerCreditTransferInitiationV04.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV04.SupplementaryData => SupplementaryData;
}
