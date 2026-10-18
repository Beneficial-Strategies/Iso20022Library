// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record FinancialInstitutionIdentification23 : IFinancialInstitutionIdentification23
{
    IClearingSystemMemberIdentification2? IFinancialInstitutionIdentification23.ClearingSystemMemberIdentification => ClearingSystemMemberIdentification;
    IGenericFinancialIdentification1? IFinancialInstitutionIdentification23.Other => Other;
    IPostalAddress27? IFinancialInstitutionIdentification23.PostalAddress => PostalAddress;
}
