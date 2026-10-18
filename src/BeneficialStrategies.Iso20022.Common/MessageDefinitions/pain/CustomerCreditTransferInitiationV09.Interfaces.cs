// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerCreditTransferInitiationV09 : ICustomerCreditTransferInitiationV09
{
    IGroupHeader85 ICustomerCreditTransferInitiationV09.GroupHeader => GroupHeader;
    IPaymentInstruction30 ICustomerCreditTransferInitiationV09.PaymentInformation => PaymentInformation;
    ISupplementaryData1? ICustomerCreditTransferInitiationV09.SupplementaryData => SupplementaryData;
}
