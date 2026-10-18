// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction144 : IPaymentTransaction144
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction144.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges12> IPaymentTransaction144.ChargesInformation => ChargesInformation;
    ITrackerData1? IPaymentTransaction144.TrackerData => TrackerData;
    IOriginalTransactionReference35? IPaymentTransaction144.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction144.SupplementaryData => SupplementaryData;
}
