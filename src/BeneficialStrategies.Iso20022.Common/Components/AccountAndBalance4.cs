// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
[IsoId("_QSzlR9p-Ed-ak6NoX_4Aeg_237043718")]
[DisplayName("Account And Balance")]
public record AccountAndBalance4
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QSzlSNp-Ed-ak6NoX_4Aeg_123204652")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_QSzlSdp-Ed-ak6NoX_4Aeg_-1069395630")]
    [DisplayName("Confirmed Balance")]
    [IsoXmlTag("ConfdBal")]
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; }
}
