// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparties.
/// </summary>
[IsoId("_vLZH0ZQFEeiILOjNP8ro1w")]
[DisplayName("Counterparty Specific Data")]
public partial record CounterpartySpecificData22
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_vXFacZQFEeiILOjNP8ro1w")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required TradeCounterpartyReport9 Counterparty { get; init; } 
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_vXGBgZQFEeiILOjNP8ro1w")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public ContractValuationData3? Valuation { get; init; } 
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_vXGBg5QFEeiILOjNP8ro1w")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public TradeCollateralReport2? Collateral { get; init; } 
    
    /// <summary>
    /// Date and time of reporting to the trade repository as required by regulation.
    /// </summary>
    [IsoId("_vXGBhZQFEeiILOjNP8ro1w")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; } 
    
    
    #nullable disable
    
}
