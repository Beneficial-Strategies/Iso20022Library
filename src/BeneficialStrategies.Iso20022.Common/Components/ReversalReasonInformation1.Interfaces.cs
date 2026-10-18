// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReversalReasonInformation1 : IReversalReasonInformation1
{
    IPartyIdentification8? IReversalReasonInformation1.ReversalOriginator => ReversalOriginator;
    IReversalReason1Choice? IReversalReasonInformation1.ReversalReason => ReversalReason;
    IEnumerable<IsoMax105Text> IReversalReasonInformation1.AdditionalReversalReasonInformation => AdditionalReversalReasonInformation;
}
