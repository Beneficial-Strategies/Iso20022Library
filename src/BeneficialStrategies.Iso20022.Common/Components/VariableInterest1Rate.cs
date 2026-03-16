// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the index used to define the rate and optionaly the basis point spread.
/// </summary>
[IsoId("_Qkr_dtp-Ed-ak6NoX_4Aeg_1444401531")]
[DisplayName("Variable Interest 1 Rate")]
public record VariableInterest1Rate
{
    /// <summary>
    /// Specifies the index taken into account to calculate the variable interest rate.
    /// </summary>
    [IsoId("_Qk1wcNp-Ed-ak6NoX_4Aeg_-276733537")]
    [DisplayName("Index")]
    [IsoXmlTag("Indx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Index { get; init; }

    /// <summary>
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_Qk1wcdp-Ed-ak6NoX_4Aeg_-1323070567")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? BasisPointSpread { get; init; }
}
