// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate22 : IMandate22
{
    IMandateAdjustment1? IMandate22.Adjustment => Adjustment;
    IMandateAuthentication1? IMandate22.Authentication => Authentication;
    IPartyIdentification272 IMandate22.Creditor => Creditor;
    ICashAccount40? IMandate22.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IMandate22.CreditorAgent => CreditorAgent;
    IPartyIdentification272? IMandate22.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification272 IMandate22.Debtor => Debtor;
    ICashAccount40? IMandate22.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IMandate22.DebtorAgent => DebtorAgent;
    IMandateOccurrences5? IMandate22.Occurrences => Occurrences;
    IMandateSetupReason1Choice? IMandate22.Reason => Reason;
    IEnumerable<IReferredMandateDocument2> IMandate22.ReferredDocument => ReferredDocument;
    IMandateTypeInformation2? IMandate22.Type => Type;
    IPartyIdentification272? IMandate22.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IMandate22.UltimateDebtor => UltimateDebtor;
}
