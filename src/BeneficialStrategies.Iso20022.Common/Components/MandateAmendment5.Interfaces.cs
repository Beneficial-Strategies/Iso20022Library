// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateAmendment5 : IMandateAmendment5
{
    IOriginalMessageInformation1? IMandateAmendment5.OriginalMessageInformation => OriginalMessageInformation;
    IMandateAmendmentReason1 IMandateAmendment5.AmendmentReason => AmendmentReason;
    IMandate8 IMandateAmendment5.Mandate => Mandate;
    IOriginalMandate4Choice IMandateAmendment5.OriginalMandate => OriginalMandate;
    IEnumerable<ISupplementaryData1> IMandateAmendment5.SupplementaryData => SupplementaryData;
}
