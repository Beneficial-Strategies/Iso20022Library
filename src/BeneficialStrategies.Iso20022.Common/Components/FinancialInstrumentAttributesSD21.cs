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
[IsoId("_MlVMgw-qEeuE0Pnt-OcNOA")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD21
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
    [IsoId("_MlVMhQ-qEeuE0Pnt-OcNOA")]
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
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_MlVMhA-qEeuE0Pnt-OcNOA")]
    [DisplayName("Originating Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtgSctyId")]
    #endif
    [IsoXmlTag("OrgtgSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #else
    public OtherIdentification2? OriginatingSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the underlying security is a money market instrument.
    /// </summary>
    [IsoId("_S5G3sQ-qEeuE0Pnt-OcNOA")]
    [DisplayName("Money Market Instrument Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyMktInstrmFlg")]
    #endif
    [IsoXmlTag("MnyMktInstrmFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MoneyMarketInstrumentFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MoneyMarketInstrumentFlag { get; init; } 
    #else
    public System.String? MoneyMarketInstrumentFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
