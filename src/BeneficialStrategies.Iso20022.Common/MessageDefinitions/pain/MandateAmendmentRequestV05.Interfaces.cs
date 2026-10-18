// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV05 : IMandateAmendmentRequestV05
{
    IGroupHeader47 IMandateAmendmentRequestV05.GroupHeader => GroupHeader;
    IMandateAmendment5 IMandateAmendmentRequestV05.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
    ISupplementaryData1? IMandateAmendmentRequestV05.SupplementaryData => SupplementaryData;
}
