// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment3 : IMandateAmendment3
{
    IOriginalMessageInformation1? IMandateAmendment3.OriginalMessageInformation => OriginalMessageInformation;
    IMandateAmendmentReason1 IMandateAmendment3.AmendmentReason => AmendmentReason;
    IMandate3 IMandateAmendment3.Mandate => Mandate;
    IOriginalMandate2Choice IMandateAmendment3.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAmendment3.SupplementaryData => SupplementaryData;
}
