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
/// Parameters of a physical delivery.
/// </summary>
[IsoId("_VMU4_9p-Ed-ak6NoX_4Aeg_-1776273308")]
[DisplayName("Delivery Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveryParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveryParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveryParameters2( System.String reqRegisteredAddressIndicator )
    {
        RegisteredAddressIndicator = reqRegisteredAddressIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the address for the physical delivery is the registered address.
    /// </summary>
    [IsoId("_VMU5ANp-Ed-ak6NoX_4Aeg_-1646980441")]
    [DisplayName("Registered Address Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdAdrInd")]
    #endif
    [IsoXmlTag("RegdAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator RegisteredAddressIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegisteredAddressIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegisteredAddressIndicator { get; init; } 
    #else
    public System.String RegisteredAddressIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Name and address to/from which the physical delivery/receipt of the financial instrument must take place.
    /// </summary>
    [IsoId("_VMU5Adp-Ed-ak6NoX_4Aeg_-1646980710")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress1? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress1? NameAndAddress { get; init; } 
    #else
    public NameAndAddress1? NameAndAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
