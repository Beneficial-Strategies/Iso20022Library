// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate23 : IMandate23
{
    IMandateAdjustment1? IMandate23.Adjustment => Adjustment;
    IMandateAuthentication1? IMandate23.Authentication => Authentication;
    IPartyIdentification272 IMandate23.Creditor => Creditor;
    ICashAccount40? IMandate23.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IMandate23.CreditorAgent => CreditorAgent;
    IPartyIdentification272? IMandate23.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification272 IMandate23.Debtor => Debtor;
    ICashAccount40? IMandate23.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IMandate23.DebtorAgent => DebtorAgent;
    IEnumerable<IsoMax35Text> IMandate23.MandateIdentification => MandateIdentification;
    IMandateOccurrences5? IMandate23.Occurrences => Occurrences;
    IMandateSetupReason1Choice? IMandate23.Reason => Reason;
    IEnumerable<IReferredMandateDocument2> IMandate23.ReferredDocument => ReferredDocument;
    IEnumerable<ISupplementaryData1> IMandate23.SupplementaryData => SupplementaryData;
    IMandateTypeInformation2? IMandate23.Type => Type;
    IPartyIdentification272? IMandate23.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IMandate23.UltimateDebtor => UltimateDebtor;
}
