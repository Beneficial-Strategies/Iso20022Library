// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction1 : IDirectDebitTransaction1
{
    IMandateRelatedInformation1? IDirectDebitTransaction1.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification8? IDirectDebitTransaction1.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
