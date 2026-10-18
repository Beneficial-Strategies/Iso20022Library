// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV03 : IMandateAmendmentRequestV03
{
    IGroupHeader47 IMandateAmendmentRequestV03.GroupHeader => GroupHeader;
    IMandateAmendment3 IMandateAmendmentRequestV03.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV03.SupplementaryData => SupplementaryData;
}
