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
[IsoId("_1RnrQb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Quantity SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionQuantitySD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_1h_Cgb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Represents &quot;subscription base&quot; (Quantity2) and &quot;subscription disbursed&quot; (Quantity1) quantity elements. &quot;Subscription base quantity&quot; is the quantity of the rights security that forms the basis for calculating the payout. It is located on the distribution announcement, with the rights subscription announcement following later. &quot;Subscription disbursed quantity&quot; is the quantity of securities received in the security payout. It is located on the distribution announcement, with the rights subscription announcement following later.
    /// </summary>
    [IsoId("_1h_Cg75WEeexmbB7KsjCwA")]
    [DisplayName("Subscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptQty")]
    #endif
    [IsoXmlTag("SbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat23Choice_? SubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat23Choice_? SubscriptionQuantity { get; init; } 
    #else
    public RatioFormat23Choice_? SubscriptionQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
