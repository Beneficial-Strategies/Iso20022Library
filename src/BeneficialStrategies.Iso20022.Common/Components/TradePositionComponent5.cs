// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a component report on a trade position.
/// </summary>
[IsoId("_BmwjgQ1LEeqV4s5SpzR1dQ")]
[DisplayName("Trade Position Component")]
public partial record TradePositionComponent5
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    [IsoId("_BngxcQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData24>(){};
    
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    [IsoId("_Bngxcw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
    
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_BngxdQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Bngxdw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
