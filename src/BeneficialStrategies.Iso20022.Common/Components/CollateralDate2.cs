// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dates related to the triparty collateral instruction or transactions.
/// </summary>
[IsoId("_qxz5MRInEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Date")]
public record CollateralDate2
{
    /// <summary>
    /// Date the transaction was agreed between the trading parties.
    /// </summary>
    [IsoId("_rIKjtxInEeyZaPkaPAzTvQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_rIKjuRInEeyZaPkaPAzTvQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Date on which the financial instruments are to be delivered or received.
    /// </summary>
    [IsoId("_rIKjuxInEeyZaPkaPAzTvQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }
}
