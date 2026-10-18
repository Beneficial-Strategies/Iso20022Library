// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction11 : IDirectDebitTransaction11
{
    IMandateRelatedInformation15? IDirectDebitTransaction11.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification135? IDirectDebitTransaction11.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
