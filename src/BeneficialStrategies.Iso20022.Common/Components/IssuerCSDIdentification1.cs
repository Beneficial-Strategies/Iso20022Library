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
/// Specifies the identification of the issuer CSD (central securities depository).
/// </summary>
[IsoId("_C0Xzk-3rEeaWjpoyrnG6Rw")]
[DisplayName("Issuer CSD Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IssuerCSDIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IssuerCSDIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IssuerCSDIdentification1( System.String reqFirstTwoCharactersInstrumentIdentification )
    {
        FirstTwoCharactersInstrumentIdentification = reqFirstTwoCharactersInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification code of the Issuer CSD, using LEI; Legal Entity Identifier (LEI) is a code allocated to a party as described in ISO 17442 &apos;Financial Services - Legal Entity Identifier (LEI)&apos;.
    /// </summary>
    [IsoId("_mHn68G5BEeeOy4DIG9NBSQ")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the jurisdiction relevant for the financial instrument based on the first two characters of its instrument identification code.
    /// </summary>
    [IsoId("_NkUachJnEeiE15g1wPm3UA")]
    [DisplayName("First Two Characters Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstTwoCharsInstrmId")]
    #endif
    [IsoXmlTag("FrstTwoCharsInstrmId")]
    [IsoSimpleType(IsoSimpleType.Exact2UpperCaseAlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact2UpperCaseAlphaText FirstTwoCharactersInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FirstTwoCharactersInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FirstTwoCharactersInstrumentIdentification { get; init; } 
    #else
    public System.String FirstTwoCharactersInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the country code of the Issuer CSD, using ISO 3166 2-character code. 
    /// </summary>
    [IsoId("_C0XzlO3rEeaWjpoyrnG6Rw")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
