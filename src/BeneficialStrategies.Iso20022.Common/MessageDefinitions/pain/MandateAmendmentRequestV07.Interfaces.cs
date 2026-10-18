// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV07 : IMandateAmendmentRequestV07
{
    IGroupHeader80 IMandateAmendmentRequestV07.GroupHeader => GroupHeader;
    IMandateAmendment7 IMandateAmendmentRequestV07.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV07.SupplementaryData => SupplementaryData;
}
