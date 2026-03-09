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
/// Configuration of the PIN online verification.
/// </summary>
[IsoId("_Xf8qAYr9EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityConfiguration5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// PIN block format the security module is able to manage for online verification of the PIN.
    /// </summary>
    [IsoId("_lihz8Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINFrmt")]
    #endif
    [IsoXmlTag("PINFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PINFormat4Code? PINFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PINFormat4Code? PINFormat { get; init; } 
    #else
    public PINFormat4Code? PINFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the security module is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_5hgD0Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Length Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINLngthCpblties")]
    #endif
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PINLengthCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapabilities { get; init; } 
    #else
    public System.UInt64? PINLengthCapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
