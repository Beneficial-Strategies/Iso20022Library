// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities account.
/// </summary>
[IsoId("_QUTaE9p-Ed-ak6NoX_4Aeg_-1786414795")]
[DisplayName("Securities Account")]
public record SecuritiesAccount12
{
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUTaFNp-Ed-ak6NoX_4Aeg_-976668235")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUTaFdp-Ed-ak6NoX_4Aeg_-1767943953")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Idenfitication of the account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QUTaFtp-Ed-ak6NoX_4Aeg_-1767943945")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Type of balance.
    /// </summary>
    [IsoId("_QUTaF9p-Ed-ak6NoX_4Aeg_-1005984863")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesBalanceType6FormatChoice_? BalanceType { get; init; }

    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUTaGNp-Ed-ak6NoX_4Aeg_-932139132")]
    [DisplayName("Security Holding Form")]
    [IsoXmlTag("SctyHldgForm")]
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; }
}
