// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation16 : IMandateRelatedInformation16
{
    IAmendmentInformationDetails15? IMandateRelatedInformation16.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency36Choice? IMandateRelatedInformation16.Frequency => Frequency;
    IMandateSetupReason1Choice? IMandateRelatedInformation16.Reason => Reason;
}
