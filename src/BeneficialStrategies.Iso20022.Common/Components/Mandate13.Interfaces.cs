// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Mandate13 : IMandate13
{
    IEnumerable<IsoMax35Text> IMandate13.MandateIdentification => MandateIdentification;
    IMandateAuthentication1? IMandate13.Authentication => Authentication;
    IMandateTypeInformation2? IMandate13.Type => Type;
    IMandateOccurrences4? IMandate13.Occurrences => Occurrences;
    IMandateAdjustment1? IMandate13.Adjustment => Adjustment;
    IMandateSetupReason1Choice? IMandate13.Reason => Reason;
    IPartyIdentification135? IMandate13.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IPartyIdentification135 IMandate13.Creditor => Creditor;
    ICashAccount38? IMandate13.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6? IMandate13.CreditorAgent => CreditorAgent;
    IPartyIdentification135? IMandate13.UltimateCreditor => UltimateCreditor;
    IPartyIdentification135 IMandate13.Debtor => Debtor;
    ICashAccount38? IMandate13.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IMandate13.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IMandate13.UltimateDebtor => UltimateDebtor;
    IEnumerable<IReferredMandateDocument1> IMandate13.ReferredDocument => ReferredDocument;
    IEnumerable<ISupplementaryData1> IMandate13.SupplementaryData => SupplementaryData;
}
