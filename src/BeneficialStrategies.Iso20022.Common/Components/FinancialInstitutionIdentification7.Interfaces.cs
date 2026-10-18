// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record FinancialInstitutionIdentification7 : IFinancialInstitutionIdentification7
{
    IClearingSystemMemberIdentification2? IFinancialInstitutionIdentification7.ClearingSystemMemberIdentification => ClearingSystemMemberIdentification;
    IPostalAddress6? IFinancialInstitutionIdentification7.PostalAddress => PostalAddress;
    IGenericFinancialIdentification1? IFinancialInstitutionIdentification7.Other => Other;
}
