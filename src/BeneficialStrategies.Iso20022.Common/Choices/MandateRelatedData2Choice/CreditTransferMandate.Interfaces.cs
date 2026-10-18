// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData2Choice;

public partial record CreditTransferMandate : ICreditTransferMandate
{
    IMandateTypeInformation2? ICreditTransferMandate.Type => Type;
    IFrequency36Choice? ICreditTransferMandate.Frequency => Frequency;
    IMandateSetupReason1Choice? ICreditTransferMandate.Reason => Reason;
}
