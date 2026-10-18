// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction9 : IDirectDebitTransaction9
{
    IMandateRelatedInformation11? IDirectDebitTransaction9.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification43? IDirectDebitTransaction9.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
