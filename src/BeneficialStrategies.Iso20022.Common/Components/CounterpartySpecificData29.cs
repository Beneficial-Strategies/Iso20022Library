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
[IsoId("_nQXxmXg-Eeu3kecHd7QKUQ")]
[DisplayName("Counterparty Specific Data")]
public partial record CounterpartySpecificData29
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_ne8ZEXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required TradeCounterpartyReport14 Counterparty { get; init; } 
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_ne8ZE3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public ContractValuationData6? Valuation { get; init; } 
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// Usage: This element is not present when there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_ne8ZFXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public TradeCollateralReport5? Collateral { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    [IsoId("_ne8ZF3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Reporting Time Stamp")]
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
