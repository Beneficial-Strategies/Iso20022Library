// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation8 : IStatusReasonInformation8
{
    IPartyIdentification32? IStatusReasonInformation8.Originator => Originator;
    IStatusReason6Choice? IStatusReasonInformation8.Reason => Reason;
    IEnumerable<Max105Text> IStatusReasonInformation8.AdditionalInformation => AdditionalInformation;
}
