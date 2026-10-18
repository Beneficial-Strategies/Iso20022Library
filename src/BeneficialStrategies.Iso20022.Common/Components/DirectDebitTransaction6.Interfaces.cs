// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction6 : IDirectDebitTransaction6
{
    IMandateRelatedInformation6? IDirectDebitTransaction6.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification32? IDirectDebitTransaction6.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
