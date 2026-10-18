// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction83 : IPaymentTransaction83
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction83.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction83.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference26? IPaymentTransaction83.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction83.SupplementaryData => SupplementaryData;
}
