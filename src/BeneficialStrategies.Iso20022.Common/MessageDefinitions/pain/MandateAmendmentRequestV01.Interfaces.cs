// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV01 : IMandateAmendmentRequestV01
{
    IGroupHeader31 IMandateAmendmentRequestV01.GroupHeader => GroupHeader;
    IMandateAmendment1 IMandateAmendmentRequestV01.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
}
