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
/// Provides additional information on the collateral account of the party delivering/receiving the collateral.
/// </summary>
[IsoId("_0esxkK_8EeaE9YROwd69hA")]
[DisplayName("Collateral Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAccount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAccount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAccount4( GenericIdentification165 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral account.
    /// </summary>
    [IsoId("_BBT9k6_9EeaE9YROwd69hA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 Identification { get; init; } 
    #else
    public GenericIdentification165 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the financial instruments placed as collateral.
    /// </summary>
    [IsoId("_BBT9la_9EeaE9YROwd69hA")]
    [DisplayName("Asset Holding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstHldg")]
    #endif
    [IsoXmlTag("AsstHldg")]
    public ValueList<AssetHolding1> AssetHolding { get; init; } = new ValueList<AssetHolding1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BBT9la_9EeaE9YROwd69hA
    
    
    #nullable disable
    
}
