// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_Wfijml99Ee262vCSVgjImg")]
[DisplayName("Cash Option")]
public record CashOption89
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_WfijnF99Ee262vCSVgjImg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_WfijpF99Ee262vCSVgjImg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account9Choice_? Account { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_WfijrF99Ee262vCSVgjImg")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PostingDate { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_WfijtF99Ee262vCSVgjImg")]
    [DisplayName("Original Posting Date")]
    [IsoXmlTag("OrgnlPstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalPostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_Wfijtl99Ee262vCSVgjImg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_Wfijvl99Ee262vCSVgjImg")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; }
}
