// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation14 : IMandateRelatedInformation14
{
    IAmendmentInformationDetails13? IMandateRelatedInformation14.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency36Choice? IMandateRelatedInformation14.Frequency => Frequency;
    IMandateSetupReason1Choice? IMandateRelatedInformation14.Reason => Reason;
}
