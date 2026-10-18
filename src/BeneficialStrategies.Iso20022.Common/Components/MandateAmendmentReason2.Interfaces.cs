// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendmentReason2 : IMandateAmendmentReason2
{
    IPartyIdentification135? IMandateAmendmentReason2.Originator => Originator;
    IMandateReason1Choice IMandateAmendmentReason2.Reason => Reason;
    IEnumerable<IsoMax105Text> IMandateAmendmentReason2.AdditionalInformation => AdditionalInformation;
}
