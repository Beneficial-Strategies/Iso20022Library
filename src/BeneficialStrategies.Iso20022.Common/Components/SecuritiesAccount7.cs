// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the account identification and the account owner.
/// </summary>
[IsoId("_QUmVBdp-Ed-ak6NoX_4Aeg_-1140481020")]
[DisplayName("Securities Account")]
public record SecuritiesAccount7
{
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUmVBtp-Ed-ak6NoX_4Aeg_-887436480")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Idenfitication of the account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QUmVB9p-Ed-ak6NoX_4Aeg_-887436481")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }
}
