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
[IsoId("_DGuj8YrrEeq91phomTRDDA")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification22
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
    [IsoId("_DHeK0YrrEeq91phomTRDDA")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISIN2021Identifier? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISIN { get; init; } 
    #else
    public System.String? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_ESTmQYrrEeq91phomTRDDA")]
    [DisplayName("Unique Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqPdctIdr")]
    #endif
    [IsoXmlTag("UnqPdctIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? UniqueProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UniqueProductIdentifier { get; init; } 
    #else
    public System.String? UniqueProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_DHeK04rrEeq91phomTRDDA")]
    [DisplayName("Alternative Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrntvInstrmId")]
    #endif
    [IsoXmlTag("AltrntvInstrmId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? AlternativeInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternativeInstrumentIdentification { get; init; } 
    #else
    public System.String? AlternativeInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
