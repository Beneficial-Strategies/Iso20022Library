// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial instrument.
/// </summary>
[IsoId("_lFfFsXwgEeuQY_68iqAoCQ")]
[DisplayName("Conversion")]
public record Conversion2
{
    /// <summary>
    /// Identification of the source security.
    /// </summary>
    [IsoId("_lcDyoXwgEeuQY_68iqAoCQ")]
    [DisplayName("Source Security")]
    [IsoXmlTag("SrcScty")]
    public required FinancialInstrumentIdentification1 SourceSecurity { get; init; }

    /// <summary>
    /// Number of units of the source security.
    /// </summary>
    [IsoId("_EeuSEXwkEeuQY_68iqAoCQ")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Breakdown of units of the source security.
    /// </summary>
    [IsoId("__g-GAXwgEeuQY_68iqAoCQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit13> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("_lcDyo3wgEeuQY_68iqAoCQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
