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
/// Specifies the expected collateral type and direction.
/// </summary>
[IsoId("__DOQZYLZEeWrrO9HojbPQA")]
[DisplayName("Expected Collateral Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExpectedCollateralMovement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of collateral that will be delivered and date by which the collateral movement is expected.
    /// </summary>
    [IsoId("__cEOMYLZEeWrrO9HojbPQA")]
    [DisplayName("Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dlvry")]
    #endif
    [IsoXmlTag("Dlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralMovement9? Delivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMovement9? Delivery { get; init; } 
    #else
    public CollateralMovement9? Delivery { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral that will be returned and date by which the collateral movement is expected.
    /// </summary>
    [IsoId("__cEOM4LZEeWrrO9HojbPQA")]
    [DisplayName("Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rtr")]
    #endif
    [IsoXmlTag("Rtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralMovement9? Return { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMovement9? Return { get; init; } 
    #else
    public CollateralMovement9? Return { get; set; } 
    #endif
    
    
    #nullable disable
    
}
