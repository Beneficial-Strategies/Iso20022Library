// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction150 : IPaymentTransaction150
{
    IEnumerable<ICharges16> IPaymentTransaction150.ChargesInformation => ChargesInformation;
    IEnumerable<IDocument15> IPaymentTransaction150.EnclosedFile => EnclosedFile;
    IOriginalTransactionReference40? IPaymentTransaction150.OriginalTransactionReference => OriginalTransactionReference;
    IPaymentConditionStatus2? IPaymentTransaction150.PaymentConditionStatus => PaymentConditionStatus;
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction150.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ISupplementaryData1> IPaymentTransaction150.SupplementaryData => SupplementaryData;
}
