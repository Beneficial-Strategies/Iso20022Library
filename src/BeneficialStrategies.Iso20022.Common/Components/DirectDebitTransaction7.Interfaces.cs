// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction7 : IDirectDebitTransaction7
{
    IMandateRelatedInformation8? IDirectDebitTransaction7.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification43? IDirectDebitTransaction7.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
