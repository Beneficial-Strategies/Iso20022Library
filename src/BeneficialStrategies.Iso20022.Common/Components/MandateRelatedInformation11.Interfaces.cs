// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation11 : IMandateRelatedInformation11
{
    IAmendmentInformationDetails11? IMandateRelatedInformation11.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency36Choice? IMandateRelatedInformation11.Frequency => Frequency;
    IMandateSetupReason1Choice? IMandateRelatedInformation11.Reason => Reason;
}
