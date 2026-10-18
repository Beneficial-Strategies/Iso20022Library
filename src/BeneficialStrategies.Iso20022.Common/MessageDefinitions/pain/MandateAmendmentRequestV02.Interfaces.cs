// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV02 : IMandateAmendmentRequestV02
{
    IGroupHeader47 IMandateAmendmentRequestV02.GroupHeader => GroupHeader;
    IMandateAmendment2 IMandateAmendmentRequestV02.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV02.SupplementaryData => SupplementaryData;
}
