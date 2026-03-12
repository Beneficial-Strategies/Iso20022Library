// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the query criteria related to securities.
/// </summary>
[IsoId("_YwmEUdGREeaQk737TH1Fzw")]
[DisplayName("Trade Security Identification Query Criteria")]
public partial record TradeSecurityIdentificationQueryCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_Y5Yz8dGREeaQk737TH1Fzw")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; } 
    
    /// <summary>
    /// Identification of the product through ISIN or AII.
    /// </summary>
    [IsoId("_Y5Yz89GREeaQk737TH1Fzw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type. 
    /// </summary>
    [IsoId("_Y5Yz9dGREeaQk737TH1Fzw")]
    [DisplayName("Underlying Instrument Identification")]
    [IsoXmlTag("UndrlygInstrmId")]
    public SecurityIdentificationQuery3Choice_? UnderlyingInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
