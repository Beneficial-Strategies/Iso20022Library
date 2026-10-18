// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails9 : IAmendmentInformationDetails9
{
    IPartyIdentification43? IAmendmentInformationDetails9.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails9.OriginalCreditorAgent => OriginalCreditorAgent;
    IPartyIdentification43? IAmendmentInformationDetails9.OriginalDebtor => OriginalDebtor;
    ICashAccount24? IAmendmentInformationDetails9.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails9.OriginalDebtorAgent => OriginalDebtorAgent;
}
