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
/// Proprietary or domestic identification scheme that uniquely identifies a security.
/// </summary>
[IsoId("_SlI0Q9p-Ed-ak6NoX_4Aeg_735400890")]
[DisplayName("Alternate Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternateSecurityIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternateSecurityIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternateSecurityIdentification3( System.String reqIdentification,string reqDomesticIdentificationSource,System.String reqProprietaryIdentificationSource )
    {
        Identification = reqIdentification;
        DomesticIdentificationSource = reqDomesticIdentificationSource;
        ProprietaryIdentificationSource = reqProprietaryIdentificationSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_SlI0RNp-Ed-ak6NoX_4Aeg_735401045")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_SlI0Rdp-Ed-ak6NoX_4Aeg_735400907")]
    [DisplayName("Domestic Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmstIdSrc")]
    #endif
    [IsoXmlTag("DmstIdSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode DomesticIdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string DomesticIdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string DomesticIdentificationSource { get; init; } 
    #else
    public string DomesticIdentificationSource { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_SlI0Rtp-Ed-ak6NoX_4Aeg_735400960")]
    [DisplayName("Proprietary Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryIdSrc")]
    #endif
    [IsoXmlTag("PrtryIdSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProprietaryIdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProprietaryIdentificationSource { get; init; } 
    #else
    public System.String ProprietaryIdentificationSource { get; set; } 
    #endif
    
    
    #nullable disable
    
}
