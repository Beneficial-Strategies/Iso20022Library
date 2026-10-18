// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendmentReason1 : IMandateAmendmentReason1
{
    IPartyIdentification43? IMandateAmendmentReason1.Originator => Originator;
    IMandateReason1Choice IMandateAmendmentReason1.Reason => Reason;
    IEnumerable<IsoMax105Text> IMandateAmendmentReason1.AdditionalInformation => AdditionalInformation;
}
