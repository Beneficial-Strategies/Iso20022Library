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
/// Provides details about the collateral held by party A and/or B.
/// </summary>
[IsoId("_UmfA9tp-Ed-ak6NoX_4Aeg_1045581242")]
[DisplayName("Collateral Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralBalance1( ActiveCurrencyAndAmount reqHeldByPartyA,ActiveCurrencyAndAmount reqHeldByPartyB )
    {
        HeldByPartyA = reqHeldByPartyA;
        HeldByPartyB = reqHeldByPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Collateral currently held by party A.
    /// </summary>
    [IsoId("_UmfA99p-Ed-ak6NoX_4Aeg_-266938996")]
    [DisplayName("Held By Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HeldByPtyA")]
    #endif
    [IsoXmlTag("HeldByPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount HeldByPartyA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount HeldByPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount HeldByPartyA { get; init; } 
    #else
    public ActiveCurrencyAndAmount HeldByPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral currently held by party B.
    /// </summary>
    [IsoId("_UmfA-Np-Ed-ak6NoX_4Aeg_-332033306")]
    [DisplayName("Held By Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HeldByPtyB")]
    #endif
    [IsoXmlTag("HeldByPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount HeldByPartyB { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount HeldByPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount HeldByPartyB { get; init; } 
    #else
    public ActiveCurrencyAndAmount HeldByPartyB { get; set; } 
    #endif
    
    
    #nullable disable
    
}
