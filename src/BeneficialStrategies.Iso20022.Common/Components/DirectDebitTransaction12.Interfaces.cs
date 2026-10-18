// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction12 : IDirectDebitTransaction12
{
    IMandateRelatedInformation16? IDirectDebitTransaction12.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification272? IDirectDebitTransaction12.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
