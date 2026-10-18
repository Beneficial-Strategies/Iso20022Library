// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate7Choice;

public partial record OriginalMandate : IOriginalMandate
{
    IMandateAuthentication1? IOriginalMandate.Authentication => Authentication;
    IMandateTypeInformation2? IOriginalMandate.Type => Type;
    IMandateOccurrences4? IOriginalMandate.Occurrences => Occurrences;
    IMandateAdjustment1? IOriginalMandate.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IOriginalMandate.Reason => Reason;
    IPartyIdentification135? IOriginalMandate.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification135 IOriginalMandate.Creditor => Creditor;
    ICashAccount38? IOriginalMandate.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalMandate.CreditorAgent => CreditorAgent;
    IPartyIdentification135? IOriginalMandate.UltimateCreditor => UltimateCreditor;
    IPartyIdentification135 IOriginalMandate.Debtor => Debtor;
    ICashAccount38? IOriginalMandate.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IOriginalMandate.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IOriginalMandate.UltimateDebtor => UltimateDebtor;
    IReferredMandateDocument1? IOriginalMandate.ReferredDocument => ReferredDocument;
}
