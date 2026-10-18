// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate21 : IMandate21
{
    IMandateAdjustment1? IMandate21.Adjustment => Adjustment;
    IMandateAuthentication1? IMandate21.Authentication => Authentication;
    IPartyIdentification272? IMandate21.Creditor => Creditor;
    ICashAccount40? IMandate21.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IMandate21.CreditorAgent => CreditorAgent;
    IPartyIdentification272? IMandate21.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification272? IMandate21.Debtor => Debtor;
    ICashAccount40? IMandate21.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IMandate21.DebtorAgent => DebtorAgent;
    IMandateOccurrences5? IMandate21.Occurrences => Occurrences;
    IMandateSetupReason1Choice? IMandate21.Reason => Reason;
    IEnumerable<IReferredMandateDocument2> IMandate21.ReferredDocument => ReferredDocument;
    IMandateTypeInformation2? IMandate21.Type => Type;
    IPartyIdentification272? IMandate21.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IMandate21.UltimateDebtor => UltimateDebtor;
}
