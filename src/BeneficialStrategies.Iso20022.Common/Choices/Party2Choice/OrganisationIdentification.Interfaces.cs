// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party2Choice;

public partial record OrganisationIdentification : IOrganisationIdentification
{
    IGenericIdentification3? IOrganisationIdentification.ProprietaryIdentification => ProprietaryIdentification;
}
