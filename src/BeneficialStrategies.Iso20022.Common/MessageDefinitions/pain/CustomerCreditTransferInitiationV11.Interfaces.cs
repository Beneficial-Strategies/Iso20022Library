// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV11 : ICustomerCreditTransferInitiationV11
{
    IGroupHeader95 ICustomerCreditTransferInitiationV11.GroupHeader => GroupHeader;
    IPaymentInstruction40 ICustomerCreditTransferInitiationV11.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV11.SupplementaryData => SupplementaryData;
}
