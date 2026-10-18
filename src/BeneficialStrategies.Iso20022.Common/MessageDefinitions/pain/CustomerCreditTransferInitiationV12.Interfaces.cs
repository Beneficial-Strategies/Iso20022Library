// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV12 : ICustomerCreditTransferInitiationV12
{
    IGroupHeader114 ICustomerCreditTransferInitiationV12.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction44> ICustomerCreditTransferInitiationV12.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICustomerCreditTransferInitiationV12.SupplementaryData => SupplementaryData;
}
