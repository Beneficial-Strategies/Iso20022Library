// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the entitlement.
/// </summary>
[IsoId("_UJRggtp-Ed-ak6NoX_4Aeg_-1393093293")]
[DisplayName("Entitlement")]
public record Entitlement1
{
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_UJRgg9p-Ed-ak6NoX_4Aeg_-505589087")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_UJRghNp-Ed-ak6NoX_4Aeg_-505589086")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Provides information about the securities distribution.
    /// </summary>
    [IsoId("_UJRghdp-Ed-ak6NoX_4Aeg_1936794544")]
    [DisplayName("Securities Distribution Details")]
    [IsoXmlTag("SctiesDstrbtnDtls")]
    public SecuritiesEntitlement1? SecuritiesDistributionDetails { get; init; }

    /// <summary>
    /// Provides information about the cash distribution.
    /// </summary>
    [IsoId("_UJRghtp-Ed-ak6NoX_4Aeg_1939563150")]
    [DisplayName("Cash Distribution Details")]
    [IsoXmlTag("CshDstrbtnDtls")]
    public CashEntitlement1? CashDistributionDetails { get; init; }
}
