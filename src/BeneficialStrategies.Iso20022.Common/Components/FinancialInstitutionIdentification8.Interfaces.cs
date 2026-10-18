// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record FinancialInstitutionIdentification8 : IFinancialInstitutionIdentification8
{
    IClearingSystemMemberIdentification2? IFinancialInstitutionIdentification8.ClearingSystemMemberIdentification => ClearingSystemMemberIdentification;
    IPostalAddress6? IFinancialInstitutionIdentification8.PostalAddress => PostalAddress;
    IGenericFinancialIdentification1? IFinancialInstitutionIdentification8.Other => Other;
}
