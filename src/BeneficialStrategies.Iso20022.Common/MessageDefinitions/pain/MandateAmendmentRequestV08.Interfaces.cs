// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAmendmentRequestV08 : IMandateAmendmentRequestV08
{
    IGroupHeader110 IMandateAmendmentRequestV08.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IMandateAmendmentRequestV08.SupplementaryData => SupplementaryData;
    IEnumerable<IMandateAmendment8> IMandateAmendmentRequestV08.UnderlyingAmendmentDetails => UnderlyingAmendmentDetails;
}
