// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_T_mAE9p-Ed-ak6NoX_4Aeg_-1024389793")]
[DisplayName("Securities Account")]
public record SecuritiesAccount14
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.”.
    /// </summary>
    [IsoId("_T_mAFNp-Ed-ak6NoX_4Aeg_-1138228859")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_T_mAFdp-Ed-ak6NoX_4Aeg_-1843343474")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode2Choice_? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_T_mAFtp-Ed-ak6NoX_4Aeg_1454551469")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
