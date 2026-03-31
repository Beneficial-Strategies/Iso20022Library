// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_ol7pkdASEeuSBa1PsnseFg")]
[DisplayName("Cash Account")]
public record CashAccount205
{
    /// <summary>
    /// Currency of the settlement.
    /// </summary>
    [IsoId("_o68QQ9ASEeuSBa1PsnseFg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Cash account for settlement.
    /// </summary>
    [IsoId("_o68QRdASEeuSBa1PsnseFg")]
    [DisplayName("Primary Account")]
    [IsoXmlTag("PmryAcct")]
    public CashAccount206? PrimaryAccount { get; init; }

    /// <summary>
    /// Sub-division of a master or omnibus cash account.
    /// </summary>
    [IsoId("_o68QR9ASEeuSBa1PsnseFg")]
    [DisplayName("Secondary Account")]
    [IsoXmlTag("ScndryAcct")]
    public CashAccount206? SecondaryAccount { get; init; }
}
