// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendmentReason3 : IMandateAmendmentReason3
{
    IEnumerable<IsoMax105Text> IMandateAmendmentReason3.AdditionalInformation => AdditionalInformation;
    IPartyIdentification272? IMandateAmendmentReason3.Originator => Originator;
    IMandateReason1Choice IMandateAmendmentReason3.Reason => Reason;
}
