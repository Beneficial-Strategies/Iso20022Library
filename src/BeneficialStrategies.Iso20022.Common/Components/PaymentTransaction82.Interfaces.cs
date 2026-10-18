// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction82 : IPaymentTransaction82
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction82.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction82.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference24? IPaymentTransaction82.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction82.SupplementaryData => SupplementaryData;
}
