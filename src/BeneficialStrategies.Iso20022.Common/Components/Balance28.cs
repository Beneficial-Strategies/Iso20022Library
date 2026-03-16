// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card account balance.
/// </summary>
[IsoId("_WhkGsaybEeupy7O5H7ITjQ")]
[DisplayName("Balance")]
public record Balance28
{
    /// <summary>
    /// Type of card account balance.
    /// </summary>
    [IsoId("_Wl6bMaybEeupy7O5H7ITjQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType15Code Type { get; init; }

    /// <summary>
    /// Other card account balance type.
    /// </summary>
    [IsoId("_Wl6bM6ybEeupy7O5H7ITjQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_Wl6bNaybEeupy7O5H7ITjQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the account.
    /// </summary>
    [IsoId("_Wl6bN6ybEeupy7O5H7ITjQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Indicates whether the value of the balance id positive or negative.
    /// </summary>
    [IsoId("_Wl6bOaybEeupy7O5H7ITjQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Indicates whether the value of balance is expressed in the currency of the cardholder or not.
    /// True: Balance is expressed in the currency of the cardholder
    /// False: Balance is expressed in a different currency.
    /// </summary>
    [IsoId("_Wl6bO6ybEeupy7O5H7ITjQ")]
    [DisplayName("Cardholder Currency Indicator")]
    [IsoXmlTag("CrdhldrCcyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderCurrencyIndicator { get; init; }

    /// <summary>
    /// Date of the balance.
    /// </summary>
    [IsoId("_Wl6bPaybEeupy7O5H7ITjQ")]
    [DisplayName("Balance Date")]
    [IsoXmlTag("BalDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BalanceDate { get; init; }
}
