// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction129 : IPaymentTransaction129
{
    IEnumerable<IStatusReasonInformation12> IPaymentTransaction129.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges7> IPaymentTransaction129.ChargesInformation => ChargesInformation;
    ITrackerData1? IPaymentTransaction129.TrackerData => TrackerData;
    IOriginalTransactionReference35? IPaymentTransaction129.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction129.SupplementaryData => SupplementaryData;
}
