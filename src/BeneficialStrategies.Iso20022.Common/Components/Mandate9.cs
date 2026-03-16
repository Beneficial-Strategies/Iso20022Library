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
[IsoId("_c4CjZ0jwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate")]
public record Mandate9
{
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_dBASJ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_dBASKUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    [IsoId("_jArg0WoGEearR-CA7eRZXQ")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_dBASK0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_dBASLUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences4? Occurrences { get; init; }

    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    [IsoId("_Zx4UIGn0EearR-CA7eRZXQ")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    [IsoId("_eWoD8WnvEearR-CA7eRZXQ")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_dBASL0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_dBASMUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    [IsoId("_JHq7cWoGEearR-CA7eRZXQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_dBASM0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_dBASNUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_dBASN0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_dBASOUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_dBASO0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_dBASPUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_dBASP0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_dBASQUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_dBASQ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_dBASRUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    [IsoId("_OHvTIGnyEearR-CA7eRZXQ")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_dBASR0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredMandateDocument1? ReferredDocument { get; init; }
}
