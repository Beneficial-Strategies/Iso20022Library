// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction69 : IPaymentTransaction69
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction69.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction69.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference23? IPaymentTransaction69.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction69.SupplementaryData => SupplementaryData;
}
