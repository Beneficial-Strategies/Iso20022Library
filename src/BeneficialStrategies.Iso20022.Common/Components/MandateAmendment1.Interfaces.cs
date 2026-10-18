// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment1 : IMandateAmendment1
{
    IOriginalMessageInformation1? IMandateAmendment1.OriginalMessageInformation => OriginalMessageInformation;
    IAmendmentReasonInformation1 IMandateAmendment1.AmendmentReason => AmendmentReason;
    IMandateInformation3 IMandateAmendment1.Mandate => Mandate;
    IOriginalMandate1Choice IMandateAmendment1.OriginalMandate => OriginalMandate;
}
