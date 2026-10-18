// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation11 : IStatusReasonInformation11
{
    IPartyIdentification125? IStatusReasonInformation11.Originator => Originator;
    IStatusReason6Choice? IStatusReasonInformation11.Reason => Reason;
    IEnumerable<IsoMax105Text> IStatusReasonInformation11.AdditionalInformation => AdditionalInformation;
}
