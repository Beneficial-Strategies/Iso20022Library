// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction10 : IDirectDebitTransaction10
{
    IMandateRelatedInformation14? IDirectDebitTransaction10.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification135? IDirectDebitTransaction10.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
