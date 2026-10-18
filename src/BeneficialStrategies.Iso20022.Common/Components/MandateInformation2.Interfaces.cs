// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateInformation2 : IMandateInformation2
{
    IMandateTypeInformation1? IMandateInformation2.Type => Type;
    IMandateOccurrences1? IMandateInformation2.Occurrences => Occurrences;
    IPartyIdentification32? IMandateInformation2.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification32 IMandateInformation2.Creditor => Creditor;
    ICashAccount16? IMandateInformation2.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification4? IMandateInformation2.CreditorAgent => CreditorAgent;
    IPartyIdentification32? IMandateInformation2.UltimateCreditor => UltimateCreditor;
    IPartyIdentification32 IMandateInformation2.Debtor => Debtor;
    ICashAccount16? IMandateInformation2.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4 IMandateInformation2.DebtorAgent => DebtorAgent;
    IPartyIdentification32? IMandateInformation2.UltimateDebtor => UltimateDebtor;
    IReferredDocumentInformation3? IMandateInformation2.ReferredDocument => ReferredDocument;
}
