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
/// Provides ownership details  of a person on an asset.
/// </summary>
[IsoId("_6_92AIzzEemXJvzC2Wyt1g")]
[DisplayName("Ownership")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Ownership1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of ownership.
    /// </summary>
    [IsoId("_ZauvUYz0EemXJvzC2Wyt1g")]
    [DisplayName("Ownership Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshTp")]
    #endif
    [IsoXmlTag("OwnrshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OwnershipType3Choice_? OwnershipType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnershipType3Choice_? OwnershipType { get; init; } 
    #else
    public OwnershipType3Choice_? OwnershipType { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of ownership that a person has on an asset.
    /// </summary>
    [IsoId("_jeCnUIz0EemXJvzC2Wyt1g")]
    [DisplayName("Ownership Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshPctg")]
    #endif
    [IsoXmlTag("OwnrshPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OwnershipPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OwnershipPercentage { get; init; } 
    #else
    public System.Decimal? OwnershipPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of usufruct that a person has on an asset.
    /// </summary>
    [IsoId("_8KqSEIz0EemXJvzC2Wyt1g")]
    [DisplayName("Usufruct Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsfrctPctg")]
    #endif
    [IsoXmlTag("UsfrctPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? UsufructPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UsufructPercentage { get; init; } 
    #else
    public System.Decimal? UsufructPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
