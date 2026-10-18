// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV05 : ICustomerCreditTransferInitiationV05
{
    IGroupHeader48 ICustomerCreditTransferInitiationV05.GroupHeader => GroupHeader;
    IPaymentInstruction9 ICustomerCreditTransferInitiationV05.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV05.SupplementaryData => SupplementaryData;
}
