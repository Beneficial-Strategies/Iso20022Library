// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction169 : IPaymentTransaction169
{
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction169.StatusReasonInformation => StatusReasonInformation;
    IPaymentConditionStatus2? IPaymentTransaction169.PaymentConditionStatus => PaymentConditionStatus;
    IEnumerable<ICharges16> IPaymentTransaction169.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference46? IPaymentTransaction169.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IDocument15> IPaymentTransaction169.EnclosedFile => EnclosedFile;
    IEnumerable<ISupplementaryData1> IPaymentTransaction169.SupplementaryData => SupplementaryData;
}
