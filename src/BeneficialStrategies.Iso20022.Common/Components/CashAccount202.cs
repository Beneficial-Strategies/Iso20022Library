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
[IsoId("_zWv7cTfjEei6RvewLQWEqw")]
[DisplayName("Cash Account")]
public record CashAccount202
{
    /// <summary>
    /// Currency of the settlement.
    /// </summary>
    [IsoId("_znHSszfjEei6RvewLQWEqw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Cash account for settlement.
    /// </summary>
    [IsoId("_j5MkQUnqEeiZP-CimVE7Hg")]
    [DisplayName("Primary Account")]
    [IsoXmlTag("PmryAcct")]
    public CashAccount203? PrimaryAccount { get; init; }

    /// <summary>
    /// Sub-division of a master or omnibus cash account.
    /// </summary>
    [IsoId("_znHSuTfjEei6RvewLQWEqw")]
    [DisplayName("Secondary Account")]
    [IsoXmlTag("ScndryAcct")]
    public CashAccount203? SecondaryAccount { get; init; }
}
