// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation10 : IMandateRelatedInformation10
{
    IAmendmentInformationDetails10? IMandateRelatedInformation10.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency21Choice? IMandateRelatedInformation10.Frequency => Frequency;
    IMandateSetupReason1Choice? IMandateRelatedInformation10.Reason => Reason;
}
