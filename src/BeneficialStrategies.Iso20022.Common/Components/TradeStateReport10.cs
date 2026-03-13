// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details for a trade state report.
/// </summary>
[IsoId("_pgIsUQ1LEeqV4s5SpzR1dQ")]
[DisplayName("Trade State Report")]
public partial record TradeStateReport10
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_phGVoQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];
    
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("_phGVow1LEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public required CommonTradeDataReport39 CommonTradeData { get; init; } 
    
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_phGVpQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_phGVpw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
