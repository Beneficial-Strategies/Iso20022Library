// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateInformation3 : IMandateInformation3
{
    IMandateTypeInformation1? IMandateInformation3.Type => Type;
    IMandateOccurrences1? IMandateInformation3.Occurrences => Occurrences;
    IPartyIdentification32? IMandateInformation3.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification32? IMandateInformation3.Creditor => Creditor;
    ICashAccount16? IMandateInformation3.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification4? IMandateInformation3.CreditorAgent => CreditorAgent;
    IPartyIdentification32? IMandateInformation3.UltimateCreditor => UltimateCreditor;
    IPartyIdentification32? IMandateInformation3.Debtor => Debtor;
    ICashAccount16? IMandateInformation3.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4? IMandateInformation3.DebtorAgent => DebtorAgent;
    IPartyIdentification32? IMandateInformation3.UltimateDebtor => UltimateDebtor;
    IReferredDocumentInformation3? IMandateInformation3.ReferredDocument => ReferredDocument;
}
