// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Traded venue related fields.
/// </summary>
[IsoId("_MyNrMUmXEeqmSrLQiFB8FA")]
[DisplayName("Trading Venue Attributes")]
public record TradingVenueAttributes2
{
    /// <summary>
    /// Segment MIC for the trading venue or systematic internaliser, where applicable, otherwise the operating MIC.
    /// </summary>
    [IsoId("_MzYI10mXEeqmSrLQiFB8FA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Identification { get; init; }

    /// <summary>
    /// Indicates whether the issuer of the financial instrument has requested or approved the trading or admission to trading of their financial instruments on a trading venue.
    /// Usage: when not present, the indicator in not applicable.
    /// </summary>
    [IsoId("_MzYI2UmXEeqmSrLQiFB8FA")]
    [DisplayName("Issuer Request")]
    [IsoXmlTag("IssrReq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IssuerRequest { get; init; }

    /// <summary>
    /// Date and time the issuer has approved the admission to trading or trading of its financial instruments on the trading venue.
    /// </summary>
    [IsoId("_MzYI20mXEeqmSrLQiFB8FA")]
    [DisplayName("Admission Approval Date By Issuer")]
    [IsoXmlTag("AdmssnApprvlDtByIssr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AdmissionApprovalDateByIssuer { get; init; }

    /// <summary>
    /// Date and time when the request for admission on the trading venue was made for the instrument.
    /// </summary>
    [IsoId("_MzYI3UmXEeqmSrLQiFB8FA")]
    [DisplayName("Request For Admission Date")]
    [IsoXmlTag("ReqForAdmssnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestForAdmissionDate { get; init; }

    /// <summary>
    /// Date and time of the admission to trading on the trading venue or the date and time when the instrument was first traded or an order or quote was first received by the trading venue.
    /// </summary>
    [IsoId("_MzYI30mXEeqmSrLQiFB8FA")]
    [DisplayName("First Trade Date")]
    [IsoXmlTag("FrstTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FirstTradeDate { get; init; }

    /// <summary>
    /// Date and time when the financial instrument ceases to be traded or to be admitted to trading on the trading venue. Where this date and time is unavailable, the field shall not be populated.
    /// </summary>
    [IsoId("_MzYI4UmXEeqmSrLQiFB8FA")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TerminationDate { get; init; }
}
