// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation12 : IStatusReasonInformation12
{
    IPartyIdentification135? IStatusReasonInformation12.Originator => Originator;
    IStatusReason6Choice? IStatusReasonInformation12.Reason => Reason;
    IEnumerable<IsoMax105Text> IStatusReasonInformation12.AdditionalInformation => AdditionalInformation;
}
