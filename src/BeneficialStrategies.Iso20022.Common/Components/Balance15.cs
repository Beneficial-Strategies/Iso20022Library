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
[IsoId("_Fwe7QEUSEeea-M6VZkEPUw")]
[DisplayName("Balance")]
public record Balance15
{
    /// <summary>
    /// Type of card account balance.
    /// </summary>
    [IsoId("_oJ_iEEUSEeea-M6VZkEPUw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType14Code Type { get; init; }

    /// <summary>
    /// Other card account balance type.
    /// </summary>
    [IsoId("_zHWngEUSEeea-M6VZkEPUw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_5k1oUEUSEeea-M6VZkEPUw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the account
    /// </summary>
    [IsoId("_AbuAkEUTEeea-M6VZkEPUw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Indicates whether the value of the balance id positive or negative.
    /// </summary>
    [IsoId("_JUXcQEUTEeea-M6VZkEPUw")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }

    /// <summary>
    /// Indicates whether the value of balance is expressed in the currency of the cardholder or not.
    /// True: Balance is expressed in the currency of the cardholder
    /// False: Balance is expressed in a different currency.
    /// </summary>
    [IsoId("_hsI4YEUTEeea-M6VZkEPUw")]
    [DisplayName("Cardholder Currency Indicator")]
    [IsoXmlTag("CrdhldrCcyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderCurrencyIndicator { get; init; }

    /// <summary>
    /// Date of the balance.
    /// </summary>
    [IsoId("_n0y4sEUTEeea-M6VZkEPUw")]
    [DisplayName("Balance Date")]
    [IsoXmlTag("BalDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BalanceDate { get; init; }
}
