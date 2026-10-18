// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransaction8 : IDirectDebitTransaction8
{
    IMandateRelatedInformation10? IDirectDebitTransaction8.MandateRelatedInformation => MandateRelatedInformation;
    IPartyIdentification43? IDirectDebitTransaction8.CreditorSchemeIdentification => CreditorSchemeIdentification;
}
