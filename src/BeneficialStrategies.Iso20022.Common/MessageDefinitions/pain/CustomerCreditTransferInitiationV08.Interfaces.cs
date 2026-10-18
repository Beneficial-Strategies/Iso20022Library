// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV08 : ICustomerCreditTransferInitiationV08
{
    IGroupHeader48 ICustomerCreditTransferInitiationV08.GroupHeader => GroupHeader;
    IPaymentInstruction22 ICustomerCreditTransferInitiationV08.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV08.SupplementaryData => SupplementaryData;
}
