// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_Y12XRx77EeSxevWRRWxNAg")]
public interface IMandate6 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_ZG1Zdx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text MandateIdentification { get; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_ZG1ZeR77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    IsoMax35Text? MandateRequestIdentification { get; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_ZG1Zex77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IMandateTypeInformation1? Type { get; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_ZG1ZfR77EeSxevWRRWxNAg")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    IMandateOccurrences3? Occurrences { get; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_ZG1Zfx77EeSxevWRRWxNAg")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    ActiveCurrencyAndAmount? CollectionAmount { get; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_ZG1ZgR77EeSxevWRRWxNAg")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    ActiveCurrencyAndAmount? MaximumAmount { get; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_i98BUSL0EeSizvrwx7oJNQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_ZG1Zgx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification43? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_ZG1ZhR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification43? Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_ZG1Zhx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_ZG1ZiR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? CreditorAgent { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_ZG1Zix77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification43? UltimateCreditor { get; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_ZG1ZjR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification43? Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_ZG1Zjx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_ZG1ZkR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? DebtorAgent { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_ZG1Zkx77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification43? UltimateDebtor { get; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_ZG1ZlR77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    IEnumerable<IReferredDocumentInformation6> ReferredDocument { get; }
}
