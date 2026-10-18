// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate20 : IMandate20
{
    IMandateAdjustment1? IMandate20.Adjustment => Adjustment;
    IMandateAuthentication1? IMandate20.Authentication => Authentication;
    IPartyIdentification272 IMandate20.Creditor => Creditor;
    ICashAccount40? IMandate20.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IMandate20.CreditorAgent => CreditorAgent;
    IPartyIdentification272? IMandate20.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification272 IMandate20.Debtor => Debtor;
    ICashAccount40? IMandate20.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IMandate20.DebtorAgent => DebtorAgent;
    IMandateOccurrences5? IMandate20.Occurrences => Occurrences;
    IMandateSetupReason1Choice? IMandate20.Reason => Reason;
    IEnumerable<IReferredMandateDocument2> IMandate20.ReferredDocument => ReferredDocument;
    IMandateTypeInformation2? IMandate20.Type => Type;
    IPartyIdentification272? IMandate20.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IMandate20.UltimateDebtor => UltimateDebtor;
}
