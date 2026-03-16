// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to fully identify a proprietary bank transaction code.
/// </summary>
[IsoId("_TVRQtdp-Ed-ak6NoX_4Aeg_1519549154")]
[DisplayName("Proprietary Bank Transaction Code Structure")]
public record ProprietaryBankTransactionCodeStructure1
{
    /// <summary>
    /// Proprietary bank transaction code to identify the underlying transaction.
    /// </summary>
    [IsoId("_TVRQttp-Ed-ak6NoX_4Aeg_1519549163")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Code { get; init; }

    /// <summary>
    /// Identification of the issuer of the proprietary bank transaction code.
    /// </summary>
    [IsoId("_TVRQt9p-Ed-ak6NoX_4Aeg_2005322670")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
