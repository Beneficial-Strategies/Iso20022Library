// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the driver or vehicle card.
/// </summary>
[IsoId("_ZjY8EUYlEfCJpvfyM9roFQ")]
[DisplayName("Driver Or Vehicle Card Data1")]
public record DriverOrVehicleCardData1
{
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    [IsoId("_ZlxhsUYlEfCJpvfyM9roFQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax20Text? Identification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_LgaJgkYlEfCJpvfyM9roFQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_LgaJg0YlEfCJpvfyM9roFQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
