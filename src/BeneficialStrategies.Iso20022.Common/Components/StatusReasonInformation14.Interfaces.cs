// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation14 : IStatusReasonInformation14
{
    IPartyIdentification272? IStatusReasonInformation14.Originator => Originator;
    IStatusReason6Choice? IStatusReasonInformation14.Reason => Reason;
    IEnumerable<Max105Text> IStatusReasonInformation14.AdditionalInformation => AdditionalInformation;
}
