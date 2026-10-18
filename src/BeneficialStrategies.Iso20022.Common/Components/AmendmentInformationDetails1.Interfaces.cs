// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails1 : IAmendmentInformationDetails1
{
    IPartyIdentification8? IAmendmentInformationDetails1.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification3? IAmendmentInformationDetails1.OriginalCreditorAgent => OriginalCreditorAgent;
    ICashAccount7? IAmendmentInformationDetails1.OriginalCreditorAgentAccount => OriginalCreditorAgentAccount;
    IPartyIdentification8? IAmendmentInformationDetails1.OriginalDebtor => OriginalDebtor;
    ICashAccount7? IAmendmentInformationDetails1.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification3? IAmendmentInformationDetails1.OriginalDebtorAgent => OriginalDebtorAgent;
    ICashAccount7? IAmendmentInformationDetails1.OriginalDebtorAgentAccount => OriginalDebtorAgentAccount;
}
