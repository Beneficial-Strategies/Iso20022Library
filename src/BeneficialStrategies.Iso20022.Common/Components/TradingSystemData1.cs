// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trading system related data.
/// </summary>
[IsoId("_mkybkGFdEfC-1NkZ9TkdKA")]
[DisplayName("Trading System Data1")]
public record TradingSystemData1
{
    /// <summary>
    /// Identification of the trading venue on which the instrument status is valid.
    /// </summary>
    [IsoId("_xvy7cGFdEfC-1NkZ9TkdKA")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public required IsoMICIdentifier TradingVenue { get; init; }

    /// <summary>
    /// Data related to the status of the trading system.
    /// </summary>
    [IsoId("__TZDUGFdEfC-1NkZ9TkdKA")]
    [DisplayName("Trading System Type")]
    [IsoXmlTag("TradgSysTp")]
    public required TradingSystemType1Code TradingSystemType { get; init; }

    /// <summary>
    /// Status of the trading system.
    /// </summary>
    [IsoId("_OG2HQKUPEfCmoeslmyBN5Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TradingSystemStatus1Code Status { get; init; }

    /// <summary>
    /// Date and time from which the system status is valid.
    /// </summary>
    [IsoId("_HZ01oKUPEfCmoeslmyBN5Q")]
    [DisplayName("Status Start Date Time")]
    [IsoXmlTag("StsStartDtTm")]
    public required IsoISODateTime StatusStartDateTime { get; init; }

    /// <summary>
    /// Date and time on which the data are disseminated by the Consolidated Tape Provider (CTP).
    ///
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_5Kt04GFdEfC-1NkZ9TkdKA")]
    [DisplayName("Dissemination Date Time")]
    [IsoXmlTag("DssmntnDtTm")]
    public IsoISODateTime? DisseminationDateTime { get; init; }
}
