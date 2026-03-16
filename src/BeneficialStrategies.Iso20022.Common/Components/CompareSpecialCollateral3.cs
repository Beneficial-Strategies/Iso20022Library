// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a collateral code.
/// </summary>
[IsoId("_G4ux4a5iEeuo-IflVgGqiA")]
[DisplayName("Compare Special Collateral")]
public record CompareSpecialCollateral3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_HHx6ga5iEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SpecialCollateral1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_HHx6g65iEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SpecialCollateral1Code? Value2 { get; init; }
}
