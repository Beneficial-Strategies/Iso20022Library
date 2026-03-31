// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number assigned by a government agency to identify foreign nationals.
/// </summary>
[IsoId("_Ax_6INokEeC60axPepSq7g_1367334821")]
[DisplayName("Securities Account")]
public record SecuritiesAccount3
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Ax_6IdokEeC60axPepSq7g_1253495755")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Choice between a code and a data source scheme to identify the type of account.
    /// </summary>
    [IsoId("_Ax_6ItokEeC60axPepSq7g_370262468")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode5Choice_? Type { get; init; }

    /// <summary>
    /// .
    /// </summary>
    [IsoId("_AyJrINokEeC60axPepSq7g_-626809885")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
