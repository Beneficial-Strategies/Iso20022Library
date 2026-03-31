// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry transaction
/// </summary>
[IsoId("_B_z74YzIEeujJfnIQ4NlpQ")]
[DisplayName("Transaction")]
public record Transaction140
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_CE9hoYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_CE9ho4zIEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_BBipUbXnEeusf7oR9YukCg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_CE9hpYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_CE9hp4zIEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification18 TransactionIdentification { get; init; }

    /// <summary>
    /// Further details of some or all amounts in the transaction amount.
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent.
    /// </summary>
    [IsoId("_CE9hqYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_CE9hq4zIEeujJfnIQ4NlpQ")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_CE9hrYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Balance of an account.
    /// </summary>
    [IsoId("_CE9hr4zIEeujJfnIQ4NlpQ")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalance2> AccountBalance { get; init; } = [];

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_CE9hsYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_CE9hs4zIEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_CE9htYzIEeujJfnIQ4NlpQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
