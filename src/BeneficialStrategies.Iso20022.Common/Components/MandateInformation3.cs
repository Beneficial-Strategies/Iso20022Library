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
[IsoId("_T3P8a9p-Ed-ak6NoX_4Aeg_1018029248")]
[DisplayName("Mandate Information")]
public record MandateInformation3
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_T3P8bNp-Ed-ak6NoX_4Aeg_1018029309")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_T3P8bdp-Ed-ak6NoX_4Aeg_1018029278")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_T3ZGUNp-Ed-ak6NoX_4Aeg_1018030197")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <summary>
    /// Set of elements used to provide details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_T3ZGUdp-Ed-ak6NoX_4Aeg_1018030166")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences1? Occurrences { get; init; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_T3ZGUtp-Ed-ak6NoX_4Aeg_1018029340")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_T3ZGU9p-Ed-ak6NoX_4Aeg_1018029363")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_T3ZGVNp-Ed-ak6NoX_4Aeg_1018030320")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_T3ZGVdp-Ed-ak6NoX_4Aeg_1018029673")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification32? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_T3ZGVtp-Ed-ak6NoX_4Aeg_1018029402")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_T3ZGV9p-Ed-ak6NoX_4Aeg_1018030105")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_T3ZGWNp-Ed-ak6NoX_4Aeg_1018029734")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_T3ZGWdp-Ed-ak6NoX_4Aeg_1018029765")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification32? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_T3i3UNp-Ed-ak6NoX_4Aeg_1018029425")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_T3i3Udp-Ed-ak6NoX_4Aeg_1018030135")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_T3i3Utp-Ed-ak6NoX_4Aeg_1018029796")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <summary>
    /// Set of elements used to provide information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_T3i3U9p-Ed-ak6NoX_4Aeg_1018030258")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }
}
