// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction68 : IPaymentTransaction68
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction68.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction68.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference22? IPaymentTransaction68.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction68.SupplementaryData => SupplementaryData;
}
