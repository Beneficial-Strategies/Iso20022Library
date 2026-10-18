// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_dTODi0jwEeaVLL5QKJ4f-A")]
public interface IMandate10 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_dceGJ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IEnumerable<IsoMax35Text> MandateIdentification { get; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_dceGKUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    IsoMax35Text MandateRequestIdentification { get; }

    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    [IsoId("_fE0IMGoGEearR-CA7eRZXQ")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    IMandateAuthentication1? Authentication { get; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_dceGK0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IMandateTypeInformation2? Type { get; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_dceGLUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    IMandateOccurrences4? Occurrences { get; }

    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    [IsoId("_KrblMZdhEea1K6JAcAwoVg")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    IsoTrueFalseIndicator TrackingIndicator { get; }

    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    [IsoId("_n9rlUWoREearR-CA7eRZXQ")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    ActiveCurrencyAndAmount? FirstCollectionAmount { get; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_dceGL0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    ActiveCurrencyAndAmount? CollectionAmount { get; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_dceGMUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    ActiveCurrencyAndAmount? MaximumAmount { get; }

    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    [IsoId("_LKg88WoGEearR-CA7eRZXQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    IMandateAdjustment1? Adjustment { get; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_dceGM0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_dceGNUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification43? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_dceGN0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification43 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_dceGOUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_dceGO0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? CreditorAgent { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_dceGPUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification43? UltimateCreditor { get; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_dceGP0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification43 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_dceGQUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_dceGQ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 DebtorAgent { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_dceGRUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification43? UltimateDebtor { get; }

    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    [IsoId("_0HLqsZR3EeazAtAtDSg0Nw")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    IsoMax35Text? MandateReference { get; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_dceGR0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    IEnumerable<IReferredMandateDocument1> ReferredDocument { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements within the message component.
    /// </summary>
    [IsoId("_dceGSUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
