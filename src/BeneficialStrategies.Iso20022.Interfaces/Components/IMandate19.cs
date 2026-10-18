// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_fdUzYdcZEeqRFcf2R4bPBw")]
public interface IMandate19 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_feuhldcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IEnumerable<IsoMax35Text> MandateIdentification { get; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_feuhl9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    IsoMax35Text MandateRequestIdentification { get; }

    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    [IsoId("_feuhmdcZEeqRFcf2R4bPBw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    IMandateAuthentication1? Authentication { get; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_feuhm9cZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IMandateTypeInformation2? Type { get; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_feuhndcZEeqRFcf2R4bPBw")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    IMandateOccurrences5? Occurrences { get; }

    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    [IsoId("_feuhn9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    IsoTrueFalseIndicator TrackingIndicator { get; }

    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    [IsoId("_feuhodcZEeqRFcf2R4bPBw")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    ActiveCurrencyAndAmount? FirstCollectionAmount { get; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_feuho9cZEeqRFcf2R4bPBw")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    ActiveCurrencyAndAmount? CollectionAmount { get; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_feuhpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    ActiveCurrencyAndAmount? MaximumAmount { get; }

    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    [IsoId("_feuhp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    IMandateAdjustment1? Adjustment { get; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_feuhqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_feuhq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification135? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_feuhrdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification135 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_feuhr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_feuhsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? CreditorAgent { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_feuhs9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification135? UltimateCreditor { get; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_feuhtdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification135 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_feuht9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_feuhudcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6 DebtorAgent { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_feuhu9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification135? UltimateDebtor { get; }

    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    [IsoId("_feuhvdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    IsoMax35Text? MandateReference { get; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_feuhv9cZEeqRFcf2R4bPBw")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    IEnumerable<IReferredMandateDocument1> ReferredDocument { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements within the message component.
    /// </summary>
    [IsoId("_feuhwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
