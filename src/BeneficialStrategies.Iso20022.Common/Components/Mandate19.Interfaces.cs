// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate19 : IMandate19
{
    IEnumerable<IsoMax35Text> IMandate19.MandateIdentification => MandateIdentification;
    IMandateAuthentication1? IMandate19.Authentication => Authentication;
    IMandateTypeInformation2? IMandate19.Type => Type;
    IMandateOccurrences5? IMandate19.Occurrences => Occurrences;
    IMandateAdjustment1? IMandate19.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IMandate19.Reason => Reason;
    IPartyIdentification135? IMandate19.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification135 IMandate19.Creditor => Creditor;
    ICashAccount40? IMandate19.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6? IMandate19.CreditorAgent => CreditorAgent;
    IPartyIdentification135? IMandate19.UltimateCreditor => UltimateCreditor;
    IPartyIdentification135 IMandate19.Debtor => Debtor;
    ICashAccount40? IMandate19.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IMandate19.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IMandate19.UltimateDebtor => UltimateDebtor;
    IEnumerable<IReferredMandateDocument1> IMandate19.ReferredDocument => ReferredDocument;
    IEnumerable<ISupplementaryData1> IMandate19.SupplementaryData => SupplementaryData;
}
