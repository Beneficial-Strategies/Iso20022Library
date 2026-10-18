// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV07 : ICustomerCreditTransferInitiationV07
{
    IGroupHeader48 ICustomerCreditTransferInitiationV07.GroupHeader => GroupHeader;
    IPaymentInstruction20 ICustomerCreditTransferInitiationV07.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV07.SupplementaryData => SupplementaryData;
}
