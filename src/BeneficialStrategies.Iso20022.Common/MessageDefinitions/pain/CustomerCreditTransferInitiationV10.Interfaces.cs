// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV10 : ICustomerCreditTransferInitiationV10
{
    IGroupHeader95 ICustomerCreditTransferInitiationV10.GroupHeader => GroupHeader;
    IPaymentInstruction34 ICustomerCreditTransferInitiationV10.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV10.SupplementaryData => SupplementaryData;
}
