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
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[IsoId("_f72qkWEUEe2P-L9DBerEgA")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_f8tmM2EUEe2P-L9DBerEgA")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISIN { get; init; } 
    #else
    public System.String? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_f8tmNWEUEe2P-L9DBerEgA")]
    [DisplayName("Unique Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqPdctIdr")]
    #endif
    [IsoXmlTag("UnqPdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueProductIdentifier2Choice_? UniqueProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueProductIdentifier2Choice_? UniqueProductIdentifier { get; init; } 
    #else
    public UniqueProductIdentifier2Choice_? UniqueProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_f8tmN2EUEe2P-L9DBerEgA")]
    [DisplayName("Alternative Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrntvInstrmId")]
    #endif
    [IsoXmlTag("AltrntvInstrmId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AlternativeInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternativeInstrumentIdentification { get; init; } 
    #else
    public System.String? AlternativeInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a human readable description of the product.
    /// </summary>
    [IsoId("_f8tmOWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctDesc")]
    #endif
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? ProductDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductDescription { get; init; } 
    #else
    public System.String? ProductDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
