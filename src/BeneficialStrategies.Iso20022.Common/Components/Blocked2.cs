// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a blocked account.
/// </summary>
[IsoId("_EGbMcSGeEeWKAaDJcYGKLw")]
[DisplayName("Blocked")]
public partial record Blocked2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the order or transaction type for which the account is blocked.
    /// </summary>
    [IsoId("_EjSuoSGeEeWKAaDJcYGKLw")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<OrderType2Choice_> OrderType { get; init; } = new ValueList<OrderType2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _EjSuoSGeEeWKAaDJcYGKLw
    
    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    [IsoId("_EjSuoyGeEeWKAaDJcYGKLw")]
    [DisplayName("Blocked")]
    [IsoXmlTag("Blckd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Blocked { get; init; } 
    
    /// <summary>
    /// Specifies the reason the account is blocked.
    /// </summary>
    [IsoId("_EjSupSGeEeWKAaDJcYGKLw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public BlockedReason1Choice_? Reason { get; init; } 
    
    
    #nullable disable
    
}
