// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
[IsoId("_UiQtgTOgEe2AEsHTM-bt1w")]
[DisplayName("Contract Valuation Data")]
public record ContractValuationData8
{
    /// <summary>
    /// Specifies the current value of the outstanding contract.
    /// </summary>
    [IsoId("_UjakEzOgEe2AEsHTM-bt1w")]
    [DisplayName("Contract Value")]
    [IsoXmlTag("CtrctVal")]
    public AmountAndDirection109? ContractValue { get; init; }

    /// <summary>
    /// Indicates the date and time of the last valuation marked to market provided by the central counterparty (CCP) or calculated using the current or last available market price of the inputs.
    /// </summary>
    [IsoId("_UjakFTOgEe2AEsHTM-bt1w")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TimeStamp { get; init; }

    /// <summary>
    /// Indicates the source and method used for the valuation of the transaction by the reporting counterparty.
    /// Usage:
    /// If at least one valuation input is used that is classified as mark-to-model, the whole valuation is classified as mark-to-model.
    /// If only inputs are used that are classified as mark-to-market; the whole valuation is classified as mark-to-market.|
    /// </summary>
    [IsoId("_UjakFzOgEe2AEsHTM-bt1w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValuationType1Code? Type { get; init; }

    /// <summary>
    /// Specifies the ratio of the absolute change in price of a derivative transaction to the change in price of the underlier, at the time a new transaction is reported or when a change in the notional amount is reported.
    /// </summary>
    [IsoId("_ZzUXcTOgEe2AEsHTM-bt1w")]
    [DisplayName("Delta")]
    [IsoXmlTag("Dlta")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? Delta { get; init; }
}
