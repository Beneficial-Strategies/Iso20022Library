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
/// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
/// </summary>
[IsoId("_QdZErtp-Ed-ak6NoX_4Aeg_-2112411865")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentification7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentification7( System.String reqISIN,AlternateSecurityIdentification3 reqOtherIdentification )
    {
        ISIN = reqISIN;
        OtherIdentification = reqOtherIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_QdZEr9p-Ed-ak6NoX_4Aeg_-2112411847")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINIdentifier ISIN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISIN { get; init; } 
    #else
    public System.String ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_QdZEsNp-Ed-ak6NoX_4Aeg_-2112411727")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlternateSecurityIdentification3 OtherIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlternateSecurityIdentification3 OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternateSecurityIdentification3 OtherIdentification { get; init; } 
    #else
    public AlternateSecurityIdentification3 OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_QdZEsdp-Ed-ak6NoX_4Aeg_-1321876969")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
