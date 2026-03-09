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
/// Context in which the transfer is performed.
/// </summary>
[IsoId("_irEvUa4sEeWLdt0vLARX2Q")]
[DisplayName("ATM Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMContext18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMContext18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMContext18( ATMService22 reqService )
    {
        Service = reqService;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    [IsoId("_i2i_ga4sEeWLdt0vLARX2Q")]
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
    /// Fund transfer service requested by the ATM inside the session.
    /// </summary>
    [IsoId("_i2i_g64sEeWLdt0vLARX2Q")]
    [DisplayName("Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svc")]
    #endif
    [IsoXmlTag("Svc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMService22 Service { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMService22 Service { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMService22 Service { get; init; } 
    #else
    public ATMService22 Service { get; set; } 
    #endif
    
    
    #nullable disable
    
}
