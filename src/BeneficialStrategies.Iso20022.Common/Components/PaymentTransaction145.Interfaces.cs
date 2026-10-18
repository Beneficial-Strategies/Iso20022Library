// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction145 : IPaymentTransaction145
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction145.StatusReasonInformation => StatusReasonInformation;
    IPaymentConditionStatus1? IPaymentTransaction145.PaymentConditionStatus => PaymentConditionStatus;
    IEnumerable<ICharges12> IPaymentTransaction145.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference38? IPaymentTransaction145.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IDocument12> IPaymentTransaction145.EnclosedFile => EnclosedFile;
    IEnumerable<ISupplementaryData1> IPaymentTransaction145.SupplementaryData => SupplementaryData;
}
