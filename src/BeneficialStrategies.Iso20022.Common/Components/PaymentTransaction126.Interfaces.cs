// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction126 : IPaymentTransaction126
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction126.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges7> IPaymentTransaction126.ChargesInformation => ChargesInformation;
    ITrackerData1? IPaymentTransaction126.TrackerData => TrackerData;
    IOriginalTransactionReference31? IPaymentTransaction126.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction126.SupplementaryData => SupplementaryData;
}
