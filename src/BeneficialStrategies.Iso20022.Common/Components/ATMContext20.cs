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
/// Context of the exception.
/// </summary>
[IsoId("_CdeSga5EEeWCgYcWSNgX5g")]
[DisplayName("ATM Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMContext20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMContext20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMContext20( ATMService24 reqService )
    {
        Service = reqService;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the exception occurred.
    /// </summary>
    [IsoId("_Cp_rka5EEeWCgYcWSNgX5g")]
    [DisplayName("Session Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SsnRef")]
    #endif
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SessionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SessionReference { get; init; } 
    #else
    public System.String? SessionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_Cp_rk65EEeWCgYcWSNgX5g")]
    [DisplayName("Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svc")]
    #endif
    [IsoXmlTag("Svc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMService24 Service { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMService24 Service { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMService24 Service { get; init; } 
    #else
    public ATMService24 Service { get; set; } 
    #endif
    
    
    #nullable disable
    
}
