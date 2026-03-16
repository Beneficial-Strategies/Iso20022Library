// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparties.
/// </summary>
[IsoId("_Be9ioZQCEeiILOjNP8ro1w")]
[DisplayName("Counterparty Specific Data")]
public record CounterpartySpecificData21
{
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_BrzEwZQCEeiILOjNP8ro1w")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required TradeCounterpartyReport8 Counterparty { get; init; }

    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_BrzEw5QCEeiILOjNP8ro1w")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public ContractValuationData3? Valuation { get; init; }

    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_BrzExZQCEeiILOjNP8ro1w")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public TradeCollateralReport2? Collateral { get; init; }

    /// <summary>
    /// Date and time of reporting to the trade repository as required by regulation.
    /// </summary>
    [IsoId("_BrzEx5QCEeiILOjNP8ro1w")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; }
}
