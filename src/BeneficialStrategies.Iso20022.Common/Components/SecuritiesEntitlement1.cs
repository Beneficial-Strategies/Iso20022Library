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
/// Provides entitlement information.
/// </summary>
[IsoId("_UJRgh9p-Ed-ak6NoX_4Aeg_1912782907")]
[DisplayName("Securities Entitlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesEntitlement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesEntitlement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesEntitlement1( SecurityIdentification7 reqSecurityIdentification,UnitOrFaceAmount1Choice_ reqEntitledSecuritiesQuantity )
    {
        SecurityIdentification = reqSecurityIdentification;
        EntitledSecuritiesQuantity = reqEntitledSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UJRgiNp-Ed-ak6NoX_4Aeg_-1841926439")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_UJbRgNp-Ed-ak6NoX_4Aeg_-1548244376")]
    [DisplayName("Entitled Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldSctiesQty")]
    #endif
    [IsoXmlTag("EntitldSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
