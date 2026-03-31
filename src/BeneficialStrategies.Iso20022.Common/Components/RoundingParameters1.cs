// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to a fractional number.
/// </summary>
[IsoId("_QRxDcNp-Ed-ak6NoX_4Aeg_-1749123923")]
[DisplayName("Rounding Parameters")]
public record RoundingParameters1
{
    /// <summary>
    /// Float value specifying the value to which rounding is required, eg, 10 means round to a multiple of 10 units/shares, 0.5 means round to a multiple of 0.5 units/shares.
    /// </summary>
    [IsoId("_QRxDcdp-Ed-ak6NoX_4Aeg_-1749123921")]
    [DisplayName("Rounding Modulus")]
    [IsoXmlTag("RndgMdlus")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? RoundingModulus { get; init; }

    /// <summary>
    /// Rounding direction applied to fractional numbers, eg, round up.
    /// </summary>
    [IsoId("_QRxDctp-Ed-ak6NoX_4Aeg_-1749123920")]
    [DisplayName("Rounding Direction")]
    [IsoXmlTag("RndgDrctn")]
    public required RoundingDirection1Code RoundingDirection { get; init; }
}
