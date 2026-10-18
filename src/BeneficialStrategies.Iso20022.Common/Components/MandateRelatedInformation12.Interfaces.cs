// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation12 : IMandateRelatedInformation12
{
    IAmendmentInformationDetails12? IMandateRelatedInformation12.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency36Choice? IMandateRelatedInformation12.Frequency => Frequency;
    IMandateSetupReason1Choice? IMandateRelatedInformation12.Reason => Reason;
}
