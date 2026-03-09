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
/// Identifies the type of process related to an ATM message.
/// </summary>
[IsoId("_nymwQa1wEeWMg5rOByfExw")]
[DisplayName("ATM Message Function")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMMessageFunction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMMessageFunction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMMessageFunction2( MessageFunction11Code reqFunction )
    {
        Function = reqFunction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of requested function.
    /// </summary>
    [IsoId("_n-hsYa1wEeWMg5rOByfExw")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageFunction11Code Function { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageFunction11Code Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction11Code Function { get; init; } 
    #else
    public MessageFunction11Code Function { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_n-hsY61wEeWMg5rOByfExw")]
    [DisplayName("ATM Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSvcCd")]
    #endif
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMServiceCode { get; init; } 
    #else
    public System.String? ATMServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the ATM manager host.
    /// </summary>
    [IsoId("_n-hsZa1wEeWMg5rOByfExw")]
    [DisplayName("Host Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstSvcCd")]
    #endif
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HostServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostServiceCode { get; init; } 
    #else
    public System.String? HostServiceCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
