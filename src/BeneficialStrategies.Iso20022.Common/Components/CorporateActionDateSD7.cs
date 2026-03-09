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
/// Provides additional information regarding corporate action options date details.
/// </summary>
[IsoId("_SgmSUJEZEeajS_7NioJdVA")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDateSD7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDateSD7( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_u-KQYZEfEeajS_7NioJdVA")]
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
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    [IsoId("_VZJagJEeEeajS_7NioJdVA")]
    [DisplayName("Actual Early Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ActualEarlyExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ActualEarlyExpirationDate { get; init; } 
    #else
    public System.DateTime? ActualEarlyExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_O0TKQJEaEeajS_7NioJdVA")]
    [DisplayName("Actual Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ActualProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ActualProtectExpirationDate { get; init; } 
    #else
    public System.DateTime? ActualProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    [IsoId("_dvld0JEaEeajS_7NioJdVA")]
    [DisplayName("Actual Early Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ActualEarlyProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ActualEarlyProtectExpirationDate { get; init; } 
    #else
    public System.DateTime? ActualEarlyProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    [IsoId("_qBkz4JEaEeajS_7NioJdVA")]
    [DisplayName("DTC Early Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCEarlyPrtctXprtnDt")]
    #endif
    [IsoXmlTag("DTCEarlyPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DTCEarlyProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DTCEarlyProtectExpirationDate { get; init; } 
    #else
    public System.DateTime? DTCEarlyProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_er8i8JEbEeajS_7NioJdVA")]
    [DisplayName("Actual Early Cover Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyCoverPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyCoverPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ActualEarlyCoverProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ActualEarlyCoverProtectExpirationDate { get; init; } 
    #else
    public System.DateTime? ActualEarlyCoverProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    [IsoId("_qt21oJEbEeajS_7NioJdVA")]
    [DisplayName("DTC Early Cover Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCEarlyCoverPrtctXprtnDt")]
    #endif
    [IsoXmlTag("DTCEarlyCoverPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DTCEarlyCoverProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DTCEarlyCoverProtectExpirationDate { get; init; } 
    #else
    public System.DateTime? DTCEarlyCoverProtectExpirationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
