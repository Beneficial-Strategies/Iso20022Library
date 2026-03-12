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
[IsoId("_fkwfQZQHEeiILOjNP8ro1w")]
[DisplayName("Counterparty Specific Data")]
public partial record CounterpartySpecificData23
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    [IsoId("_fvdTYZQHEeiILOjNP8ro1w")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required TradeCounterpartyReport9 Counterparty { get; init; } 
    
    /// <summary>
    /// Data related to contract valuation.
    /// </summary>
    [IsoId("_fvdTY5QHEeiILOjNP8ro1w")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public ContractValuationData2? Valuation { get; init; } 
    
    /// <summary>
    /// Information related to collateral agreement between counterparties.
    /// </summary>
    [IsoId("_fvdTZZQHEeiILOjNP8ro1w")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public TradeCollateralReport1? Collateral { get; init; } 
    
    /// <summary>
    /// Date and time of reporting to the trade repository as required by regulation.
    /// </summary>
    [IsoId("_fvd6cZQHEeiILOjNP8ro1w")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; } 
    
    
    #nullable disable
    
}
