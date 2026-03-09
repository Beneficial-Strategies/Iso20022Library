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
/// Provides information about the securities movement.
/// </summary>
[IsoId("_UIO-tNp-Ed-ak6NoX_4Aeg_1695017809")]
[DisplayName("Security Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityMovement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityMovement1( SecurityIdentification7 reqSecurityIdentification,UnitOrFaceAmount1Choice_ reqSecuritiesQuantity )
    {
        SecurityIdentification = reqSecurityIdentification;
        SecuritiesQuantity = reqSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the movement.
    /// </summary>
    [IsoId("_UIO-tdp-Ed-ak6NoX_4Aeg_-1539092088")]
    [DisplayName("Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntId")]
    #endif
    [IsoXmlTag("MvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MovementIdentification { get; init; } 
    #else
    public System.String? MovementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIO-ttp-Ed-ak6NoX_4Aeg_-1084454454")]
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
    /// Quantitty of financial instrument.
    /// </summary>
    [IsoId("_UIO-t9p-Ed-ak6NoX_4Aeg_-494324592")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UIO-uNp-Ed-ak6NoX_4Aeg_139176688")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount12> AccountDetails { get; init; } = new ValueList<SecuritiesAccount12>(){};
    
    
    #nullable disable
    
}
