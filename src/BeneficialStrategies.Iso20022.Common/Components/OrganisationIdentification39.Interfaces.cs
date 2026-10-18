// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OrganisationIdentification39 : IOrganisationIdentification39
{
    IEnumerable<IGenericOrganisationIdentification3> IOrganisationIdentification39.Other => Other;
}
