// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData2Choice;

public partial record DirectDebitMandate : IDirectDebitMandate
{
    IAmendmentInformationDetails14? IDirectDebitMandate.AmendmentInformationDetails => AmendmentInformationDetails;
    IFrequency36Choice? IDirectDebitMandate.Frequency => Frequency;
    IMandateSetupReason1Choice? IDirectDebitMandate.Reason => Reason;
}
