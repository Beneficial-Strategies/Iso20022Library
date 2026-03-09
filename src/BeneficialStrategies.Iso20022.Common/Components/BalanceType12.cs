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
/// Set of elements used to define the balance type and sub-type.
/// </summary>
[IsoId("_SYoCRtp-Ed-ak6NoX_4Aeg_833472278")]
[DisplayName("Balance Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceType12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceType12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceType12( BalanceType5Choice_ reqCodeOrProprietary )
    {
        CodeOrProprietary = reqCodeOrProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded or proprietary format balance type.
    /// </summary>
    [IsoId("_SYoCR9p-Ed-ak6NoX_4Aeg_833472741")]
    [DisplayName("Code Or Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdOrPrtry")]
    #endif
    [IsoXmlTag("CdOrPrtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceType5Choice_ CodeOrProprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceType5Choice_ CodeOrProprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType5Choice_ CodeOrProprietary { get; init; } 
    #else
    public BalanceType5Choice_ CodeOrProprietary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the balance sub-type.
    /// </summary>
    [IsoId("_SYoCSNp-Ed-ak6NoX_4Aeg_834396694")]
    [DisplayName("Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTp")]
    #endif
    [IsoXmlTag("SubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceSubType1Choice_? SubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceSubType1Choice_? SubType { get; init; } 
    #else
    public BalanceSubType1Choice_? SubType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
