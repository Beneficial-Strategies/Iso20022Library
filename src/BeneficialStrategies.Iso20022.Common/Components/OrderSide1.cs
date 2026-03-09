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
/// Indicates in which direction the intention is to transfer the ownership of a financial instrument.
/// </summary>
[IsoId("_S4XSQNp-Ed-ak6NoX_4Aeg_2090952843")]
[DisplayName("Order Side")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderSide1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_S4XSQdp-Ed-ak6NoX_4Aeg_2133432264")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Side1Code? Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side1Code? Side { get; init; } 
    #else
    public Side1Code? Side { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the status request is applicable for all orders.|Yes = all orders|No = status for orders matching certain criteria further specified in this message.
    /// </summary>
    [IsoId("_S4XSQtp-Ed-ak6NoX_4Aeg_-2032239627")]
    [DisplayName("All Orders Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOrdrsInd")]
    #endif
    [IsoXmlTag("AllOrdrsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AllOrdersIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllOrdersIndicator { get; init; } 
    #else
    public System.String? AllOrdersIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
