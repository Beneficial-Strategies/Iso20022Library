// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction46 : IPaymentTransaction46
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction46.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction46.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference16? IPaymentTransaction46.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction46.SupplementaryData => SupplementaryData;
}
