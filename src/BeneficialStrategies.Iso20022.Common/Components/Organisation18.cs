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
/// Card acceptor performing the transaction.
/// </summary>
[IsoId("_HX5psXrpEeSz_of_1TY14A")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation18( GenericIdentification32 reqIdentification,System.String reqCommonName,CommunicationAddress5 reqLocation )
    {
        Identification = reqIdentification;
        CommonName = reqCommonName;
        Location = reqLocation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the card acceptor.
    /// </summary>
    [IsoId("_HkkMsXrpEeSz_of_1TY14A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 Identification { get; init; } 
    #else
    public GenericIdentification32 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the card acceptor as appearing on the receipt or the statement of account of the cardholder.
    /// It correspond to the ISO 8583 field number 43.
    /// </summary>
    [IsoId("_HkkMs3rpEeSz_of_1TY14A")]
    [DisplayName("Common Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonNm")]
    #endif
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text CommonName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CommonName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CommonName { get; init; } 
    #else
    public System.String CommonName { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the card acceptor. 
    /// It correspond to the ISO 8583 field number 43.
    /// </summary>
    [IsoId("_HkkMt3rpEeSz_of_1TY14A")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationAddress5 Location { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationAddress5 Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress5 Location { get; init; } 
    #else
    public CommunicationAddress5 Location { get; set; } 
    #endif
    
    /// <summary>
    /// Selected language of the card acceptor. Reference ISO 639-1 (alpha-2) andISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_uDglkHruEeSz_of_1TY14A")]
    [DisplayName("Selected Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SelctdLang")]
    #endif
    [IsoXmlTag("SelctdLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? SelectedLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SelectedLanguage { get; init; } 
    #else
    public string? SelectedLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card acceptor data required by a card scheme.
    /// </summary>
    [IsoId("_zEKcAHruEeSz_of_1TY14A")]
    [DisplayName("Scheme Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchmeData")]
    #endif
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SchemeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SchemeData { get; init; } 
    #else
    public System.String? SchemeData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
