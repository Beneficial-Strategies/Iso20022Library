// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Traceability10.
/// </summary>
[IsoId("_dgAwMWxjEe6wzr2RagRERg")]
[DisplayName("Traceability10")]
public record Traceability10
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required Max35Text Identification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType17Code? Type { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public Max35Text? OtherType { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType18Code? Assigner { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public Max35Text? ShortName { get; init; }

    /// <summary>
    /// Date Time In.
    /// </summary>
    [DisplayName("Date Time In")]
    [IsoXmlTag("DtTmIn")]
    public ISODateTime? DateTimeIn { get; init; }

    /// <summary>
    /// Date Time Out.
    /// </summary>
    [DisplayName("Date Time Out")]
    [IsoXmlTag("DtTmOut")]
    public ISODateTime? DateTimeOut { get; init; }
}
