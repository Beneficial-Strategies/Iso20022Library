// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_pMkMQUGVEeWqy4niLuXETA")]
[DisplayName("Securities Option")]
public record SecuritiesOption53
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_pZzXBUGVEeWqy4niLuXETA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_pZzXDUGVEeWqy4niLuXETA")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_pZzXFUGVEeWqy4niLuXETA")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity6Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_pZzXHUGVEeWqy4niLuXETA")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTimeChoice_ PostingDate { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_pZzXJUGVEeWqy4niLuXETA")]
    [DisplayName("Original Posting Date")]
    [IsoXmlTag("OrgnlPstngDt")]
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; }
}
