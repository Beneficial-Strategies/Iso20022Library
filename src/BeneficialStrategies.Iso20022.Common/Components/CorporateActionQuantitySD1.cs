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
/// Provides additional information regarding corporate action securities quantity details.
/// </summary>
[IsoId("_1SxXJTL3EeKU9IrkkToqcw_-1416431204")]
[DisplayName("Corporate Action Quantity SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionQuantitySD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionQuantitySD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionQuantitySD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1S7IIDL3EeKU9IrkkToqcw_1436572634")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Represents &quot;subscription base&quot; (Quantity2) and &quot;subscription disbursed&quot; (Quantity1) quantity elements. &quot;Subscription base quantity&quot; is the quantity of the rights security that forms the basis for calculating the payout. It is located on the distribution announcement, with the rights subscription announcement following later. &quot;Subscription disbursed quantity&quot; is the quantity of securities received in the security payout. It is located on the distribution announcement, with the rights subscription announcement following later.
    /// </summary>
    [IsoId("_1S7IITL3EeKU9IrkkToqcw_-1074072378")]
    [DisplayName("Subscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptQty")]
    #endif
    [IsoXmlTag("SbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat13Choice_? SubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat13Choice_? SubscriptionQuantity { get; init; } 
    #else
    public RatioFormat13Choice_? SubscriptionQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
