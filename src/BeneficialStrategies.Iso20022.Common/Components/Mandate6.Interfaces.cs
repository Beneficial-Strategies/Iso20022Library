// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate6 : IMandate6
{
    IMandateTypeInformation1? IMandate6.Type => Type;
    IMandateOccurrences3? IMandate6.Occurrences => Occurrences;
    IMandateSetupReason1Choice? IMandate6.Reason => Reason;
    IPartyIdentification43? IMandate6.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification43? IMandate6.Creditor => Creditor;
    ICashAccount24? IMandate6.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? IMandate6.CreditorAgent => CreditorAgent;
    IPartyIdentification43? IMandate6.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43? IMandate6.Debtor => Debtor;
    ICashAccount24? IMandate6.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IMandate6.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IMandate6.UltimateDebtor => UltimateDebtor;
    IEnumerable<IReferredDocumentInformation6> IMandate6.ReferredDocument => ReferredDocument;
}
