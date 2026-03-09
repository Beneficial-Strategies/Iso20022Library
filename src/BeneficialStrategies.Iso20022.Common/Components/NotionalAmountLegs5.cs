// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the monetary or converted amount for the derivatives transaction.
/// </summary>
[IsoId("_k1n04WEfEe2P-L9DBerEgA")]
[DisplayName("Notional Amount Legs")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalAmountLegs5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Notional amount of leg 1 which indicates monetary or converted amount for the derivatives transaction.
    /// </summary>
    [IsoId("_k2hMwWEfEe2P-L9DBerEgA")]
    [DisplayName("First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstLeg")]
    #endif
    [IsoXmlTag("FrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalAmount5? FirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalAmount5? FirstLeg { get; init; } 
    #else
    public NotionalAmount5? FirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Notional amount of leg 2 which indicates monetary or converted amount for the derivatives transaction.
    /// </summary>
    [IsoId("_k2hMw2EfEe2P-L9DBerEgA")]
    [DisplayName("Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLeg")]
    #endif
    [IsoXmlTag("ScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalAmount6? SecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalAmount6? SecondLeg { get; init; } 
    #else
    public NotionalAmount6? SecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
