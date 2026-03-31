// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit of deposited media for the customer.
/// </summary>
[IsoId("_OVrpka-XEeWJvLRJ8PsD_w")]
[DisplayName("ATM Transaction Amounts")]
public record ATMTransactionAmounts9
{
    /// <summary>
    /// Type of media.
    /// </summary>
    [IsoId("_Og2-0a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public required ATMMediaType2Code MediaType { get; init; }

    /// <summary>
    /// Currency of the media.
    /// </summary>
    [IsoId("_Og2-1a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Minimum number of media.
    /// </summary>
    [IsoId("_Og2-16-XEeWJvLRJ8PsD_w")]
    [DisplayName("Minimum Number")]
    [IsoXmlTag("MinNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumNumber { get; init; }

    /// <summary>
    /// Maximum number of media.
    /// </summary>
    [IsoId("_Og2-2a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// True if limits may be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_h9Ss4K-YEeWJvLRJ8PsD_w")]
    [DisplayName("Display Flag")]
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisplayFlag { get; init; }
}
