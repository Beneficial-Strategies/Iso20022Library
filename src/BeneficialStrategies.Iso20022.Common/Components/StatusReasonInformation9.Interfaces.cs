// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation9 : IStatusReasonInformation9
{
    IPartyIdentification43? IStatusReasonInformation9.Originator => Originator;
    IStatusReason6Choice? IStatusReasonInformation9.Reason => Reason;
    IEnumerable<Max105Text> IStatusReasonInformation9.AdditionalInformation => AdditionalInformation;
}
