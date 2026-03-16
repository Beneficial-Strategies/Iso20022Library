// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
[IsoId("_qNgYMU1BEeybj420QgWBkA")]
[DisplayName("Non Financial Response Component")]
public record NonFinancialResponseComponent2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_qUPSUU1BEeybj420QgWBkA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    [IsoId("_qUPSU01BEeybj420QgWBkA")]
    [DisplayName("Response Content")]
    [IsoXmlTag("RspnCntt")]
    public ValueList<NonFinancialResponseContentComponent2> ResponseContent { get; init; } = [];

    // ID for the above is _qUPSU01BEeybj420QgWBkA

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_qUPSVU1BEeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_qUPSV01BEeybj420QgWBkA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
