// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate2 : IMandate2
{
    IMandateTypeInformation1? IMandate2.Type => Type;
    IMandateOccurrences2? IMandate2.Occurrences => Occurrences;
    IPartyIdentification43? IMandate2.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification43 IMandate2.Creditor => Creditor;
    ICashAccount24? IMandate2.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? IMandate2.CreditorAgent => CreditorAgent;
    IPartyIdentification43? IMandate2.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43 IMandate2.Debtor => Debtor;
    ICashAccount24? IMandate2.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IMandate2.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IMandate2.UltimateDebtor => UltimateDebtor;
    IReferredDocumentInformation3? IMandate2.ReferredDocument => ReferredDocument;
}
