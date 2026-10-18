// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails6 : IAmendmentInformationDetails6
{
    IPartyIdentification32? IAmendmentInformationDetails6.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification4? IAmendmentInformationDetails6.OriginalCreditorAgent => OriginalCreditorAgent;
    ICashAccount16? IAmendmentInformationDetails6.OriginalCreditorAgentAccount => OriginalCreditorAgentAccount;
    IPartyIdentification32? IAmendmentInformationDetails6.OriginalDebtor => OriginalDebtor;
    ICashAccount16? IAmendmentInformationDetails6.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification4? IAmendmentInformationDetails6.OriginalDebtorAgent => OriginalDebtorAgent;
    ICashAccount16? IAmendmentInformationDetails6.OriginalDebtorAgentAccount => OriginalDebtorAgentAccount;
}
