// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment2 : IMandateAmendment2
{
    IOriginalMessageInformation1? IMandateAmendment2.OriginalMessageInformation => OriginalMessageInformation;
    IMandateAmendmentReason1 IMandateAmendment2.AmendmentReason => AmendmentReason;
    IMandate3 IMandateAmendment2.Mandate => Mandate;
    IOriginalMandate2Choice IMandateAmendment2.OriginalMandate => OriginalMandate;
}
