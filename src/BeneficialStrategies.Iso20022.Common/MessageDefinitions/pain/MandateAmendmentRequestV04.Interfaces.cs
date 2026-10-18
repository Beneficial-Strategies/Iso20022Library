// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV04 : IMandateAmendmentRequestV04
{
    IGroupHeader47 IMandateAmendmentRequestV04.GroupHeader => GroupHeader;
    IMandateAmendment4 IMandateAmendmentRequestV04.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV04.SupplementaryData => SupplementaryData;
}
