// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate18 : IMandate18
{
    IMandateAuthentication1? IMandate18.Authentication => Authentication;
    IMandateTypeInformation2? IMandate18.Type => Type;
    IMandateOccurrences5? IMandate18.Occurrences => Occurrences;
    IMandateAdjustment1? IMandate18.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IMandate18.Reason => Reason;
    IPartyIdentification135? IMandate18.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification135? IMandate18.Creditor => Creditor;
    ICashAccount40? IMandate18.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6? IMandate18.CreditorAgent => CreditorAgent;
    IPartyIdentification135? IMandate18.UltimateCreditor => UltimateCreditor;
    IPartyIdentification135? IMandate18.Debtor => Debtor;
    ICashAccount40? IMandate18.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IMandate18.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IMandate18.UltimateDebtor => UltimateDebtor;
    IEnumerable<IReferredMandateDocument1> IMandate18.ReferredDocument => ReferredDocument;
}
