// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferMandateData1 : ICreditTransferMandateData1
{
    IMandateTypeInformation2? ICreditTransferMandateData1.Type => Type;
    IFrequency36Choice? ICreditTransferMandateData1.Frequency => Frequency;
    IMandateSetupReason1Choice? ICreditTransferMandateData1.Reason => Reason;
}
