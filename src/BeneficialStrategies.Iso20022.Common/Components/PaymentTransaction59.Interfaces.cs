// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction59 : IPaymentTransaction59
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction59.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction59.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference21? IPaymentTransaction59.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction59.SupplementaryData => SupplementaryData;
}
