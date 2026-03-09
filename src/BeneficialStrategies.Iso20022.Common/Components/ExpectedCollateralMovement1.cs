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
[IsoId("_UmVP9dp-Ed-ak6NoX_4Aeg_571972876")]
[DisplayName("Expected Collateral Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExpectedCollateralMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of collateral that will be delivered.
    /// </summary>
    [IsoId("_UmVP9tp-Ed-ak6NoX_4Aeg_759302404")]
    [DisplayName("Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dlvry")]
    #endif
    [IsoXmlTag("Dlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType1Code? Delivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType1Code? Delivery { get; init; } 
    #else
    public CollateralType1Code? Delivery { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral that will be returned.
    /// </summary>
    [IsoId("_UmVP99p-Ed-ak6NoX_4Aeg_1623020220")]
    [DisplayName("Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rtr")]
    #endif
    [IsoXmlTag("Rtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType1Code? Return { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType1Code? Return { get; init; } 
    #else
    public CollateralType1Code? Return { get; set; } 
    #endif
    
    
    #nullable disable
    
}
