// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate8 : IMandate8
{
    IMandateAuthentication1? IMandate8.Authentication => Authentication;
    IMandateTypeInformation2? IMandate8.Type => Type;
    IMandateOccurrences4? IMandate8.Occurrences => Occurrences;
    IMandateAdjustment1? IMandate8.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IMandate8.Reason => Reason;
    IPartyIdentification43? IMandate8.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification43? IMandate8.Creditor => Creditor;
    ICashAccount24? IMandate8.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? IMandate8.CreditorAgent => CreditorAgent;
    IPartyIdentification43? IMandate8.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43? IMandate8.Debtor => Debtor;
    ICashAccount24? IMandate8.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IMandate8.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IMandate8.UltimateDebtor => UltimateDebtor;
    IEnumerable<IReferredMandateDocument1> IMandate8.ReferredDocument => ReferredDocument;
}
