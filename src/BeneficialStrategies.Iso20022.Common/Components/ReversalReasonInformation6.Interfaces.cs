// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReversalReasonInformation6 : IReversalReasonInformation6
{
    IPartyIdentification32? IReversalReasonInformation6.Originator => Originator;
    IReversalReason4Choice? IReversalReasonInformation6.Reason => Reason;
    IEnumerable<Max105Text> IReversalReasonInformation6.AdditionalInformation => AdditionalInformation;
}
