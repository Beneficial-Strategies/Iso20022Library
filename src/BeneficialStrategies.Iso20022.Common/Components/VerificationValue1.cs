// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Verification Value1.
/// </summary>
[IsoId("_otO6UHG4Ee60F8I8TAMKmg")]
[DisplayName("Verification Value1")]
public record VerificationValue1
{
    /// <summary>
    /// Binary Value.
    /// </summary>
    [DisplayName("Binary Value")]
    [IsoXmlTag("BinryVal")]
    public IsoMax5000Binary? BinaryValue { get; init; }

    /// <summary>
    /// Date Time.
    /// </summary>
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Hexadecimal Binary Value.
    /// </summary>
    [DisplayName("Hexadecimal Binary Value")]
    [IsoXmlTag("HexBinryVal")]
    public IsoMax9999HexBinaryText? HexadecimalBinaryValue { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Text Value.
    /// </summary>
    [DisplayName("Text Value")]
    [IsoXmlTag("TxtVal")]
    public IsoMax2048Text? TextValue { get; init; }

    /// <summary>
    /// Validity End Date.
    /// </summary>
    [DisplayName("Validity End Date")]
    [IsoXmlTag("VldtyEndDt")]
    public IsoISODate? ValidityEndDate { get; init; }

    /// <summary>
    /// Validity End Time.
    /// </summary>
    [DisplayName("Validity End Time")]
    [IsoXmlTag("VldtyEndTm")]
    public IsoISOTime? ValidityEndTime { get; init; }
}
