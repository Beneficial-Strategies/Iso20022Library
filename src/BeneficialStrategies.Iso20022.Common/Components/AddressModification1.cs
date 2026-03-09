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
/// Specifies the type of change to the address.
/// </summary>
[IsoId("__2QXEA4jEeK3IMoVvcTkkg")]
[DisplayName("Address Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddressModification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AddressModification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AddressModification1( PostalAddress6 reqAddress )
    {
        Address = reqAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_LfDmMA4kEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCd")]
    #endif
    [IsoXmlTag("ModCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? ModificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? ModificationCode { get; init; } 
    #else
    public Modification1Code? ModificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address.
    /// </summary>
    [IsoId("_RcjfYA4kEeK3IMoVvcTkkg")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress6 Address { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress6 Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6 Address { get; init; } 
    #else
    public PostalAddress6 Address { get; set; } 
    #endif
    
    
    #nullable disable
    
}
