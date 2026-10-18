// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate4Choice;

public partial record OriginalMandate : IOriginalMandate
{
    IMandateAuthentication1? IOriginalMandate.Authentication => Authentication;
    IMandateTypeInformation2? IOriginalMandate.Type => Type;
    IMandateOccurrences4? IOriginalMandate.Occurrences => Occurrences;
    IMandateAdjustment1? IOriginalMandate.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IOriginalMandate.Reason => Reason;
    IPartyIdentification43? IOriginalMandate.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification43 IOriginalMandate.Creditor => Creditor;
    ICashAccount24? IOriginalMandate.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalMandate.CreditorAgent => CreditorAgent;
    IPartyIdentification43? IOriginalMandate.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43 IOriginalMandate.Debtor => Debtor;
    ICashAccount24? IOriginalMandate.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IOriginalMandate.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IOriginalMandate.UltimateDebtor => UltimateDebtor;
    IReferredMandateDocument1? IOriginalMandate.ReferredDocument => ReferredDocument;
}
