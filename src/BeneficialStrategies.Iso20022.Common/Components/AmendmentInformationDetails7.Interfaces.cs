// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails7 : IAmendmentInformationDetails7
{
    IPartyIdentification43? IAmendmentInformationDetails7.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails7.OriginalCreditorAgent => OriginalCreditorAgent;
    IPartyIdentification43? IAmendmentInformationDetails7.OriginalDebtor => OriginalDebtor;
    ICashAccount16? IAmendmentInformationDetails7.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails7.OriginalDebtorAgent => OriginalDebtorAgent;
}
