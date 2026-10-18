// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentInformationDetails13 : IAmendmentInformationDetails13
{
    IPartyIdentification135? IAmendmentInformationDetails13.OriginalCreditorSchemeIdentification => OriginalCreditorSchemeIdentification;
    IBranchAndFinancialInstitutionIdentification6? IAmendmentInformationDetails13.OriginalCreditorAgent => OriginalCreditorAgent;
    ICashAccount38? IAmendmentInformationDetails13.OriginalCreditorAgentAccount => OriginalCreditorAgentAccount;
    IPartyIdentification135? IAmendmentInformationDetails13.OriginalDebtor => OriginalDebtor;
    ICashAccount38? IAmendmentInformationDetails13.OriginalDebtorAccount => OriginalDebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IAmendmentInformationDetails13.OriginalDebtorAgent => OriginalDebtorAgent;
    ICashAccount38? IAmendmentInformationDetails13.OriginalDebtorAgentAccount => OriginalDebtorAgentAccount;
    IFrequency36Choice? IAmendmentInformationDetails13.OriginalFrequency => OriginalFrequency;
    IMandateSetupReason1Choice? IAmendmentInformationDetails13.OriginalReason => OriginalReason;
}
