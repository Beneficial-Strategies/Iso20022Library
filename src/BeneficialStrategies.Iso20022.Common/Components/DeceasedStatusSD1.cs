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
/// Deceased beneficial owner information details.
/// </summary>
[IsoId("_JuPnQcX8EeexPc-mfUU5zQ")]
[DisplayName("Deceased Status SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeceasedStatusSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeceasedStatusSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeceasedStatusSD1( System.String reqBeneficialOwnerName )
    {
        BeneficialOwnerName = reqBeneficialOwnerName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which the beneficial owner is known.
    /// </summary>
    [IsoId("_5C1u8cX9EeexPc-mfUU5zQ")]
    [DisplayName("Beneficial Owner Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrNm")]
    #endif
    [IsoXmlTag("BnfclOwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BeneficialOwnerName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficialOwnerName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficialOwnerName { get; init; } 
    #else
    public System.String BeneficialOwnerName { get; set; } 
    #endif
    
    /// <summary>
    /// Date of death of the beneficial owner.
    /// </summary>
    [IsoId("_JuPnQ8X8EeexPc-mfUU5zQ")]
    [DisplayName("Death Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DthDt")]
    #endif
    [IsoXmlTag("DthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DeathDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DeathDate { get; init; } 
    #else
    public System.DateOnly? DeathDate { get; set; } 
    #endif
    
    /// <summary>
    /// Death certificate number of the beneficial owner.
    /// </summary>
    [IsoId("_JuPnRMX8EeexPc-mfUU5zQ")]
    [DisplayName("Death Certificate Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DthCertSrlNb")]
    #endif
    [IsoXmlTag("DthCertSrlNb")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? DeathCertificateSerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeathCertificateSerialNumber { get; init; } 
    #else
    public System.String? DeathCertificateSerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Jurisdiction by which the certificate of deposit was issued.
    /// </summary>
    [IsoId("_JuPnQsX8EeexPc-mfUU5zQ")]
    [DisplayName("Issuing Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssgJursdctn")]
    #endif
    [IsoXmlTag("IssgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuingJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuingJurisdiction { get; init; } 
    #else
    public System.String? IssuingJurisdiction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
