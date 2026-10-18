// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails10 : IAmendmentInformationDetails10
{
    IPartyIdentification43? IAmendmentInformationDetails10.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails10.OriginalCreditorAgent => OriginalCreditorAgent;
    ICashAccount24? IAmendmentInformationDetails10.OriginalCreditorAgentAccount => OriginalCreditorAgentAccount;
    IPartyIdentification43? IAmendmentInformationDetails10.OriginalDebtor => OriginalDebtor;
    ICashAccount24? IAmendmentInformationDetails10.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IAmendmentInformationDetails10.OriginalDebtorAgent => OriginalDebtorAgent;
    ICashAccount24? IAmendmentInformationDetails10.OriginalDebtorAgentAccount => OriginalDebtorAgentAccount;
    IFrequency21Choice? IAmendmentInformationDetails10.OriginalFrequency => OriginalFrequency;
    IMandateSetupReason1Choice? IAmendmentInformationDetails10.OriginalReason => OriginalReason;
}
