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
/// Specifies the type of the document referred in the remittance information.
/// </summary>
[IsoId("_T31yQdp-Ed-ak6NoX_4Aeg_788285148")]
[DisplayName("Referred Document Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReferredDocumentType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReferredDocumentType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReferredDocumentType1( DocumentType2Code reqCode,System.String reqProprietary )
    {
        Code = reqCode;
        Proprietary = reqProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Document type in a coded form.
    /// </summary>
    [IsoId("_T31yQtp-Ed-ak6NoX_4Aeg_1742281673")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentType2Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentType2Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType2Code Code { get; init; } 
    #else
    public DocumentType2Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of the type of the remittance document.
    /// </summary>
    [IsoId("_T31yQ9p-Ed-ak6NoX_4Aeg_1745976831")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Proprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Proprietary { get; init; } 
    #else
    public System.String Proprietary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    [IsoId("_T31yRNp-Ed-ak6NoX_4Aeg_1757060568")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
