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
/// Indicates whether the collateral is proprietarily owned or client owned.
/// </summary>
[IsoId("_fy8XnQyiEeukOZYTbzKKxw")]
[DisplayName("Collateral Ownership")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralOwnership3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralOwnership3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralOwnership3( System.String reqProprietary )
    {
        Proprietary = reqProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether collateral is owned by the clearing member or not.
    /// </summary>
    [IsoId("_gHBxIQyiEeukOZYTbzKKxw")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Proprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Proprietary { get; init; } 
    #else
    public System.String Proprietary { get; set; } 
    #endif
    
    /// <summary>
    /// Client that owns the collateral.
    /// </summary>
    [IsoId("_gHBxIwyiEeukOZYTbzKKxw")]
    [DisplayName("Client Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntNm")]
    #endif
    [IsoXmlTag("ClntNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification178Choice_? ClientName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_? ClientName { get; init; } 
    #else
    public PartyIdentification178Choice_? ClientName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
