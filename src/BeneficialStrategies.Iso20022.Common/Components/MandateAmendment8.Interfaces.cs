// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment8 : IMandateAmendment8
{
    IMandateAmendmentReason3 IMandateAmendment8.AmendmentReason => AmendmentReason;
    IMandate21 IMandateAmendment8.Mandate => Mandate;
    IOriginalMandate10Choice IMandateAmendment8.OriginalMandate => OriginalMandate;
    IOriginalMessageInformation1? IMandateAmendment8.OriginalMessageInformation => OriginalMessageInformation;
    IEnumerable<ISupplementaryData1> IMandateAmendment8.SupplementaryData => SupplementaryData;
}
