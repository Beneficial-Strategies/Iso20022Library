// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction105 : IPaymentTransaction105
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction105.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges7> IPaymentTransaction105.ChargesInformation => ChargesInformation;
    ITrackerData1? IPaymentTransaction105.TrackerData => TrackerData;
    IOriginalTransactionReference28? IPaymentTransaction105.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction105.SupplementaryData => SupplementaryData;
}
