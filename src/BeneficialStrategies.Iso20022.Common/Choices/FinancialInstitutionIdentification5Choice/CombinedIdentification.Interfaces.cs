// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice;

public partial record CombinedIdentification : ICombinedIdentification
{
    IClearingSystemMemberIdentification3Choice? ICombinedIdentification.ClearingSystemMemberIdentification => ClearingSystemMemberIdentification;
    IPostalAddress1? ICombinedIdentification.PostalAddress => PostalAddress;
    IGenericIdentification3? ICombinedIdentification.ProprietaryIdentification => ProprietaryIdentification;
}
