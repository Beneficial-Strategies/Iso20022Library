// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about the letter of intent.
/// </summary>
[IsoId("_QXVWcxKHEeKj15WxqwlXPw")]
[DisplayName("Letter Intent")]
public record LetterIntent1
{
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer.
    /// </summary>
    [IsoId("_iqLbsBKHEeKj15WxqwlXPw")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LetterIntentReference { get; init; }

    /// <summary>
    /// Amount stated on the letter of intent.
    /// </summary>
    [IsoId("_vuVOgBKHEeKj15WxqwlXPw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Start date stated on the letter of intent.
    /// </summary>
    [IsoId("_3Jsz4BKHEeKj15WxqwlXPw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// End date stated on the letter of intent.
    /// </summary>
    [IsoId("_-X9KUBKHEeKj15WxqwlXPw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }
}
