// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction136 : IPaymentTransaction136
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction136.StatusReasonInformation => StatusReasonInformation;
    IPaymentConditionStatus1? IPaymentTransaction136.PaymentConditionStatus => PaymentConditionStatus;
    IEnumerable<ICharges7> IPaymentTransaction136.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference37? IPaymentTransaction136.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IDocument12> IPaymentTransaction136.EnclosedFile => EnclosedFile;
    IEnumerable<ISupplementaryData1> IPaymentTransaction136.SupplementaryData => SupplementaryData;
}
