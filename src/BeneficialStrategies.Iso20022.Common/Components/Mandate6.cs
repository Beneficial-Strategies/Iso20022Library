// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_Y12XRx77EeSxevWRRWxNAg")]
[DisplayName("Mandate")]
public record Mandate6
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_ZG1Zdx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_ZG1ZeR77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_ZG1Zex77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_ZG1ZfR77EeSxevWRRWxNAg")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences3? Occurrences { get; init; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_ZG1Zfx77EeSxevWRRWxNAg")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_ZG1ZgR77EeSxevWRRWxNAg")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_i98BUSL0EeSizvrwx7oJNQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_ZG1Zgx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_ZG1ZhR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_ZG1Zhx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_ZG1ZiR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_ZG1Zix77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_ZG1ZjR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_ZG1Zjx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_ZG1ZkR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_ZG1Zkx77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_ZG1ZlR77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredDocumentInformation6> ReferredDocument { get; init; } = [];
}
