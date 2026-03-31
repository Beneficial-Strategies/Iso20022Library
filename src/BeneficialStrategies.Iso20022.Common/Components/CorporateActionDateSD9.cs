// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action options date details.
/// </summary>
[IsoId("_9sUmsb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Date SD")]
public record CorporateActionDateSD9
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_981u8b5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    [IsoId("_981u875WEeexmbB7KsjCwA")]
    [DisplayName("Actual Early Expiration Date")]
    [IsoXmlTag("ActlEarlyXprtnDt")]
    public DateFormat49Choice_? ActualEarlyExpirationDate { get; init; }

    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_981u9b5WEeexmbB7KsjCwA")]
    [DisplayName("Actual Protect Expiration Date")]
    [IsoXmlTag("ActlPrtctXprtnDt")]
    public DateFormat49Choice_? ActualProtectExpirationDate { get; init; }

    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    [IsoId("_981u975WEeexmbB7KsjCwA")]
    [DisplayName("Actual Early Protect Expiration Date")]
    [IsoXmlTag("ActlEarlyPrtctXprtnDt")]
    public DateFormat49Choice_? ActualEarlyProtectExpirationDate { get; init; }

    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    [IsoId("_981u-b5WEeexmbB7KsjCwA")]
    [DisplayName("DTC Early Protect Expiration Date")]
    [IsoXmlTag("DTCEarlyPrtctXprtnDt")]
    public DateFormat49Choice_? DTCEarlyProtectExpirationDate { get; init; }

    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_981u-75WEeexmbB7KsjCwA")]
    [DisplayName("Actual Early Cover Protect Expiration Date")]
    [IsoXmlTag("ActlEarlyCoverPrtctXprtnDt")]
    public DateFormat49Choice_? ActualEarlyCoverProtectExpirationDate { get; init; }

    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    [IsoId("_981u_b5WEeexmbB7KsjCwA")]
    [DisplayName("DTC Early Cover Protect Expiration Date")]
    [IsoXmlTag("DTCEarlyCoverPrtctXprtnDt")]
    public DateFormat49Choice_? DTCEarlyCoverProtectExpirationDate { get; init; }

    /// <summary>
    /// For Reorganization events, date at which instructions will be accepted by agent for payment.
    /// </summary>
    [IsoId("_oD9GMc9kEee4rfBIKt5cSg")]
    [DisplayName("Process To Date")]
    [IsoXmlTag("PrcToDt")]
    public DateFormat49Choice_? ProcessToDate { get; init; }
}
