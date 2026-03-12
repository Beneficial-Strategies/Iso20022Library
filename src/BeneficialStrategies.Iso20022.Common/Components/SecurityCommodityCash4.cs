// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the type of assets subject of the transaction.
/// </summary>
[IsoId("_A1bcjcK3EeuFNp8LZAnorg")]
[DisplayName("Security Commodity Cash")]
public partial record SecurityCommodityCash4
{
    #nullable enable
    
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_A2yHY8K3EeuFNp8LZAnorg")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security48? Security { get; init; } 
    
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_A2yHZcK3EeuFNp8LZAnorg")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity42? Commodity { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_A2yHZ8K3EeuFNp8LZAnorg")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public CashCompare3? Cash { get; init; } 
    
    
    #nullable disable
    
}
