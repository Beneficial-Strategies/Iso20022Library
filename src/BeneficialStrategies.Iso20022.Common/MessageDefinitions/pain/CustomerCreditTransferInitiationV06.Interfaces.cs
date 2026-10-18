// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV06 : ICustomerCreditTransferInitiationV06
{
    IGroupHeader48 ICustomerCreditTransferInitiationV06.GroupHeader => GroupHeader;
    IPaymentInstruction16 ICustomerCreditTransferInitiationV06.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV06.SupplementaryData => SupplementaryData;
}
