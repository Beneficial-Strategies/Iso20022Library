// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction49 : IPaymentTransaction49
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction49.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction49.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference19? IPaymentTransaction49.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction49.SupplementaryData => SupplementaryData;
}
