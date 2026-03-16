// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the account.
/// </summary>
[IsoId("_UK6fTNp-Ed-ak6NoX_4Aeg_-1336818380")]
[DisplayName("Proceeds Delivery")]
public record ProceedsDelivery1
{
    /// <summary>
    /// identification of the securities account to which the securities have to be delivered.
    /// </summary>
    [IsoId("_ULEQQNp-Ed-ak6NoX_4Aeg_-1218609739")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; }

    /// <summary>
    /// Identification of the cash account to which the cash has to be delivered.
    /// </summary>
    [IsoId("_ULEQQdp-Ed-ak6NoX_4Aeg_-1258318117")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public required CashAccountIdentification1Choice_ CashAccountIdentification { get; init; }

    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_ULEQQtp-Ed-ak6NoX_4Aeg_-1318346642")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Identification of the institution servicing the account.
    /// </summary>
    [IsoId("_ULEQQ9p-Ed-ak6NoX_4Aeg_-1220127792")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public PartyIdentification2Choice_? AccountServicerIdentification { get; init; }
}
