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
[IsoId("_T_vKAdp-Ed-ak6NoX_4Aeg_-178975462")]
[DisplayName("Securities Account")]
public record SecuritiesAccount13
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.”.
    /// </summary>
    [IsoId("_T_vKAtp-Ed-ak6NoX_4Aeg_-292814528")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_T_vKA9p-Ed-ak6NoX_4Aeg_1466291973")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification20? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_T_vKBNp-Ed-ak6NoX_4Aeg_469219620")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
