// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CancellationReasonInformation2 : ICancellationReasonInformation2
{
    IPartyIdentification32? ICancellationReasonInformation2.Originator => Originator;
    IMandateReason1Choice ICancellationReasonInformation2.Reason => Reason;
    IEnumerable<IsoMax105Text> ICancellationReasonInformation2.AdditionalInformation => AdditionalInformation;
}
