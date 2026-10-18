// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment4 : IMandateAmendment4
{
    IOriginalMessageInformation1? IMandateAmendment4.OriginalMessageInformation => OriginalMessageInformation;
    IMandateAmendmentReason1 IMandateAmendment4.AmendmentReason => AmendmentReason;
    IMandate6 IMandateAmendment4.Mandate => Mandate;
    IOriginalMandate3Choice IMandateAmendment4.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAmendment4.SupplementaryData => SupplementaryData;
}
