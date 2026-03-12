// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structure for defining asset class specific details of a derivative to be declared.
/// </summary>
[IsoId("_Hq0pRX5aEea2k7EBUopqxw")]
[DisplayName("Asset Class")]
public partial record AssetClass2
{
    #nullable enable
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type commodity as underlying.
    /// </summary>
    [IsoId("_HzdA035aEea2k7EBUopqxw")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public DerivativeCommodity2? Commodity { get; init; } 
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type interest rates as underlying.
    /// </summary>
    [IsoId("_HzdA1X5aEea2k7EBUopqxw")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public DerivativeInterest3? Interest { get; init; } 
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type foreign exchange as underlying.
    /// </summary>
    [IsoId("_HzdA135aEea2k7EBUopqxw")]
    [DisplayName("Foreign Exchange")]
    [IsoXmlTag("FX")]
    public DerivativeForeignExchange3? ForeignExchange { get; init; } 
    
    
    #nullable disable
    
}
