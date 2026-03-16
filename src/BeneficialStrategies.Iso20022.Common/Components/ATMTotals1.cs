// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Current totals of the ATM.
/// </summary>
[IsoId("_XPWq4IqdEeS4a4abTJTSSw")]
[DisplayName("ATM Totals")]
public record ATMTotals1
{
    /// <summary>
    /// Type of media inside the cassette.
    /// </summary>
    [IsoId("_H7ZjMIqeEeS4a4abTJTSSw")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public ATMMediaType1Code? MediaType { get; init; }

    /// <summary>
    /// Currency of the totals.
    /// </summary>
    [IsoId("_QIrGoIqeEeS4a4abTJTSSw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total balance of the ATM including reject cassette, but excluding the retract cassette.
    /// </summary>
    [IsoId("_iyycYIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Balance")]
    [IsoXmlTag("ATMBal")]
    public ImpliedCurrencyAndAmount? ATMBalance { get; init; }

    /// <summary>
    /// Available amount for dispense in the ATM.
    /// </summary>
    [IsoId("_pmgL4IqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Current")]
    [IsoXmlTag("ATMCur")]
    public ImpliedCurrencyAndAmount? ATMCurrent { get; init; }

    /// <summary>
    /// Total number of units for non-valued media, including reject cassette.
    /// </summary>
    [IsoId("_uaqecIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Balance Number")]
    [IsoXmlTag("ATMBalNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ATMBalanceNumber { get; init; }

    /// <summary>
    /// Total number of units for non-valued media, excluding reject cassette.
    /// </summary>
    [IsoId("_yIVqEIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Current Number")]
    [IsoXmlTag("ATMCurNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ATMCurrentNumber { get; init; }
}
