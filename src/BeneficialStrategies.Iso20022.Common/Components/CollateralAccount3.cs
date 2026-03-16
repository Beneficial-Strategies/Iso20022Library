// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral account of the party delivering/receiving the collateral.
/// </summary>
[IsoId("_o2WOMa_XEeaiqo1qOdNaWg")]
[DisplayName("Collateral Account")]
public record CollateralAccount3
{
    /// <summary>
    /// Unique identification of the collateral account.
    /// </summary>
    [IsoId("_pQE80a_XEeaiqo1qOdNaWg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Indicates the type of collateral account.
    /// </summary>
    [IsoId("_pQE806_XEeaiqo1qOdNaWg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CollateralAccountIdentificationType3Choice_? Type { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_pQE81a_XEeaiqo1qOdNaWg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
