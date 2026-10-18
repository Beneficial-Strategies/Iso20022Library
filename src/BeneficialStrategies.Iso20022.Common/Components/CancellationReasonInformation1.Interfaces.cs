// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CancellationReasonInformation1 : ICancellationReasonInformation1
{
    IPartyIdentification8? ICancellationReasonInformation1.CancellationOriginator => CancellationOriginator;
    ICancellationReason1Choice? ICancellationReasonInformation1.CancellationReason => CancellationReason;
    IEnumerable<IsoMax105Text> ICancellationReasonInformation1.AdditionalCancellationReasonInformation => AdditionalCancellationReasonInformation;
}
