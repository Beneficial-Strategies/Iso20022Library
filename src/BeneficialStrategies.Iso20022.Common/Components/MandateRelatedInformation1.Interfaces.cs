// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateRelatedInformation1 : IMandateRelatedInformation1
{
    IAmendmentInformationDetails1? IMandateRelatedInformation1.AmendmentInformationDetails => AmendmentInformationDetails;
}
