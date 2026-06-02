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
[IsoId("91ca99e7-a90f-4b5c-99b5-1ddc69b52654")]
[DisplayName("Conversion4")]
public record Conversion4
{
    /// <summary>
    /// Identification of the source security.
    /// </summary>
    [IsoId("8070ad5b-43e0-4b49-ad47-ea39d1f214bd")]
    [DisplayName("Source Security")]
    [IsoXmlTag("SrcScty")]
    public required FinancialInstrumentIdentification7 SourceSecurity { get; init; }

    /// <summary>
    /// Number of units of the source security.
    /// </summary>
    [IsoId("f5a0a888-6553-470e-bcbb-af89622c60d7")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Breakdown of units of the source security.
    /// </summary>
    [IsoId("e924641d-ccc0-4981-9c66-d0cd2cd7ed60")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit15> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("3dcb0ebc-74a4-4ba9-b7e1-29d186a415d3")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
