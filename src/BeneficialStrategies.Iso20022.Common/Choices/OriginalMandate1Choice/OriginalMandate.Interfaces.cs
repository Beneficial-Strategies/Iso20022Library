// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate1Choice;

public partial record OriginalMandate : IOriginalMandate
{
    IMandateTypeInformation1? IOriginalMandate.Type => Type;
    IMandateOccurrences1? IOriginalMandate.Occurrences => Occurrences;
    IPartyIdentification32? IOriginalMandate.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification32 IOriginalMandate.Creditor => Creditor;
    ICashAccount16? IOriginalMandate.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification4? IOriginalMandate.CreditorAgent => CreditorAgent;
    IPartyIdentification32? IOriginalMandate.UltimateCreditor => UltimateCreditor;
    IPartyIdentification32 IOriginalMandate.Debtor => Debtor;
    ICashAccount16? IOriginalMandate.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4 IOriginalMandate.DebtorAgent => DebtorAgent;
    IPartyIdentification32? IOriginalMandate.UltimateDebtor => UltimateDebtor;
    IReferredDocumentInformation3? IOriginalMandate.ReferredDocument => ReferredDocument;
}
