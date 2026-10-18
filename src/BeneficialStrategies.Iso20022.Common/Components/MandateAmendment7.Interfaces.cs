// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment7 : IMandateAmendment7
{
    IOriginalMessageInformation1? IMandateAmendment7.OriginalMessageInformation => OriginalMessageInformation;
    IMandateAmendmentReason2 IMandateAmendment7.AmendmentReason => AmendmentReason;
    IMandate18 IMandateAmendment7.Mandate => Mandate;
    IOriginalMandate9Choice IMandateAmendment7.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAmendment7.SupplementaryData => SupplementaryData;
}
