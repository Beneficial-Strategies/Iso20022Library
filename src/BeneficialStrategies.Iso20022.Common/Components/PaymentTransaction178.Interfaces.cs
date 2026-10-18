// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction178 : IPaymentTransaction178
{
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction178.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges16> IPaymentTransaction178.ChargesInformation => ChargesInformation;
    ITrackerData7? IPaymentTransaction178.TrackerData => TrackerData;
    IOriginalTransactionReference47? IPaymentTransaction178.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction178.SupplementaryData => SupplementaryData;
}
