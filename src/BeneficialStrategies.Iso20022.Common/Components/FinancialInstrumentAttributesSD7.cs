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
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_1esTQDL3EeKU9IrkkToqcw_-24344462")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributesSD7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributesSD7( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1esTQTL3EeKU9IrkkToqcw_1068806572")]
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
    /// Name of the issuer.
    /// </summary>
    [IsoId("_1esTQjL3EeKU9IrkkToqcw_-811499068")]
    [DisplayName("Issuer Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDesc")]
    #endif
    [IsoXmlTag("IssrDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? IssuerDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerDescription { get; init; } 
    #else
    public System.String? IssuerDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Country of incorporation of the issuer.
    /// </summary>
    [IsoId("_1esTQzL3EeKU9IrkkToqcw_88402598")]
    [DisplayName("Country Of Incorporation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIncorprtn")]
    #endif
    [IsoXmlTag("CtryOfIncorprtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIncorporation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIncorporation { get; init; } 
    #else
    public string? CountryOfIncorporation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the stock exchange associated to place of listing code is primary.
    /// </summary>
    [IsoId("_1esTRDL3EeKU9IrkkToqcw_-88358462")]
    [DisplayName("Primary Exchange Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryXchgFlg")]
    #endif
    [IsoXmlTag("PmryXchgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PrimaryExchangeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrimaryExchangeFlag { get; init; } 
    #else
    public System.String? PrimaryExchangeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event has been registered with US Securities Exchange Commission (SEC).
    /// </summary>
    [IsoId("_1esTRTL3EeKU9IrkkToqcw_-809173124")]
    [DisplayName("SEC Registered Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SECRegdFlg")]
    #endif
    [IsoXmlTag("SECRegdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SECRegisteredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SECRegisteredFlag { get; init; } 
    #else
    public System.String? SECRegisteredFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
