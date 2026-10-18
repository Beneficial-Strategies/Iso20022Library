// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV06 : IMandateAmendmentRequestV06
{
    IGroupHeader80 IMandateAmendmentRequestV06.GroupHeader => GroupHeader;
    IMandateAmendment6 IMandateAmendmentRequestV06.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV06.SupplementaryData => SupplementaryData;
}
