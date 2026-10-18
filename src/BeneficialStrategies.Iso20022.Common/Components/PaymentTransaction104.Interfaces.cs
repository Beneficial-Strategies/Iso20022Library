// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction104 : IPaymentTransaction104
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction104.StatusReasonInformation => StatusReasonInformation;
    IPaymentConditionStatus1? IPaymentTransaction104.PaymentConditionStatus => PaymentConditionStatus;
    IEnumerable<ICharges7> IPaymentTransaction104.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference29? IPaymentTransaction104.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IDocument12> IPaymentTransaction104.EnclosedFile => EnclosedFile;
    IEnumerable<ISupplementaryData1> IPaymentTransaction104.SupplementaryData => SupplementaryData;
}
