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
/// Provides the identification of the system and its currency.
/// </summary>
[IsoId("_HcKF0Im6Eeipw6hHPgB4Sw")]
[DisplayName("System And Currency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemAndCurrency1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemAndCurrency1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemAndCurrency1( SystemIdentification2Choice_ reqSystemIdentification )
    {
        SystemIdentification = reqSystemIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the system, as assigned by the system administrator.
    /// </summary>
    [IsoId("_dWTB4om6Eeipw6hHPgB4Sw")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemIdentification2Choice_ SystemIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemIdentification2Choice_ SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemIdentification2Choice_ SystemIdentification { get; init; } 
    #else
    public SystemIdentification2Choice_ SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_dWTB44m6Eeipw6hHPgB4Sw")]
    [DisplayName("System Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysCcy")]
    #endif
    [IsoXmlTag("SysCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SystemCurrency { get; init; } 
    #else
    public string? SystemCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
