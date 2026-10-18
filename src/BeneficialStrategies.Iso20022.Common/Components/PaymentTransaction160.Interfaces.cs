// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction160 : IPaymentTransaction160
{
    IEnumerable<ICharges16> IPaymentTransaction160.ChargesInformation => ChargesInformation;
    IOriginalTransactionReference42? IPaymentTransaction160.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IStatusReasonInformation14> IPaymentTransaction160.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ISupplementaryData1> IPaymentTransaction160.SupplementaryData => SupplementaryData;
    ITrackerData7? IPaymentTransaction160.TrackerData => TrackerData;
}
