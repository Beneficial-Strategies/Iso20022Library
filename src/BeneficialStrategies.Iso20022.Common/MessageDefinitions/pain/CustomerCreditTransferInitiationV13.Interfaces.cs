// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV13 : ICustomerCreditTransferInitiationV13
{
    IGroupHeader114 ICustomerCreditTransferInitiationV13.GroupHeader => GroupHeader;
    IEnumerable<IPaymentInstruction51> ICustomerCreditTransferInitiationV13.PaymentInformation => PaymentInformation;
    IEnumerable<ISupplementaryData1> ICustomerCreditTransferInitiationV13.SupplementaryData => SupplementaryData;
}
