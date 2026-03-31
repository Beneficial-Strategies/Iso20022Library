// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The Collateral Account provides additional information on the Collateral Account of the Party delivering the collateral.
/// </summary>
[IsoId("_vWqvNaMOEeCojJW5vEuTEQ_-992555144")]
[DisplayName("Collateral Account")]
public record CollateralAccount1
{
    /// <summary>
    /// Unique identification of the Collateral Account.
    /// </summary>
    [IsoId("_vWqvNqMOEeCojJW5vEuTEQ_-1281624236")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Indicates the Type of Collateral Account.
    /// </summary>
    [IsoId("_vWqvN6MOEeCojJW5vEuTEQ_250529344")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CollateralAccountIdentificationType1Choice_? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_vW0gMKMOEeCojJW5vEuTEQ_950989043")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
