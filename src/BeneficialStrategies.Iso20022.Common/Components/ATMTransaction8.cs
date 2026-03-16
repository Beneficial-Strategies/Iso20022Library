// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Preferred withdrawal transaction chosen by the the customer.
/// </summary>
[IsoId("_keiqMYq3EeSIDtZ76p6McQ")]
[DisplayName("ATM Transaction")]
public record ATMTransaction8
{
    /// <summary>
    /// Amount to dispense.
    /// </summary>
    [IsoId("_igfzsIq4EeSIDtZ76p6McQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [IsoId("_nDhS8Iq4EeSIDtZ76p6McQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// True if a receipt has to be printed by the ATM for the customer.
    /// </summary>
    [IsoId("_kq6SVYq3EeSIDtZ76p6McQ")]
    [DisplayName("Receipt Flag")]
    [IsoXmlTag("RctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptFlag { get; init; }

    /// <summary>
    /// True if a balance has to be printed by the ATM on the customer receipt.
    /// </summary>
    [IsoId("_D1jJUIq4EeSIDtZ76p6McQ")]
    [DisplayName("Balance Print Flag")]
    [IsoXmlTag("BalPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BalancePrintFlag { get; init; }

    /// <summary>
    /// Media mix algorithm, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    [IsoId("_kq6SUYq3EeSIDtZ76p6McQ")]
    [DisplayName("Mix Type")]
    [IsoXmlTag("MixTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MixType { get; init; }

    /// <summary>
    /// Media mix to select.
    /// </summary>
    [IsoId("_kq6SU4q3EeSIDtZ76p6McQ")]
    [DisplayName("Mix")]
    [IsoXmlTag("Mix")]
    public ValueList<ATMMediaMix2> Mix { get; init; } = [];
}
