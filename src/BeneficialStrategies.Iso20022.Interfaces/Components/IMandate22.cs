// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_1ko_YTEyEe6g-ffJsqGiSA")]
public interface IMandate22 : IIsoComponent
{
    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    IMandateAdjustment1? Adjustment { get; }

    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    IMandateAuthentication1? Authentication { get; }

    /// <summary>
    /// Fixed amount to be collected from the debtor's account.
    /// </summary>
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? CreditorAgent { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification272? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification272 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 DebtorAgent { get; }

    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; }

    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    IsoMax35Text? MandateReference { get; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    IsoMax35Text? MandateRequestIdentification { get; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor's account, per instruction.
    /// </summary>
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    IMandateOccurrences5? Occurrences { get; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    IEnumerable<IReferredMandateDocument2> ReferredDocument { get; }

    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    IsoTrueFalseIndicator TrackingIndicator { get; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IMandateTypeInformation2? Type { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification272? UltimateDebtor { get; }
}
