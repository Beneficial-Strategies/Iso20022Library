// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate2Choice;

public partial record OriginalMandate : IOriginalMandate
{
    IMandateTypeInformation1? IOriginalMandate.Type => Type;
    IMandateOccurrences2? IOriginalMandate.Occurrences => Occurrences;
    IPartyIdentification43? IOriginalMandate.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification43 IOriginalMandate.Creditor => Creditor;
    ICashAccount24? IOriginalMandate.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalMandate.CreditorAgent => CreditorAgent;
    IPartyIdentification43? IOriginalMandate.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43 IOriginalMandate.Debtor => Debtor;
    ICashAccount24? IOriginalMandate.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IOriginalMandate.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IOriginalMandate.UltimateDebtor => UltimateDebtor;
    IReferredDocumentInformation3? IOriginalMandate.ReferredDocument => ReferredDocument;
}
