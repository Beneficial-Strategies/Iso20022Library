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
/// Digital signature of data, with an asymmetric key.
/// </summary>
[IsoId("_SwiSxQEcEeCQm6a_G2yO_w_423305328")]
[DisplayName("Signed Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SignedData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SignedData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SignedData1( EncapsulatedContent1 reqEncapsulatedContent )
    {
        EncapsulatedContent = reqEncapsulatedContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SwiSxgEcEeCQm6a_G2yO_w_877392597")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_SwiSxwEcEeCQm6a_G2yO_w_569453236")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification1> DigestAlgorithm { get; init; } = new ValueList<AlgorithmIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwiSxwEcEeCQm6a_G2yO_w_569453236
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_SwiSyAEcEeCQm6a_G2yO_w_251676575")]
    [DisplayName("Encapsulated Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcpsltdCntt")]
    #endif
    [IsoXmlTag("NcpsltdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #else
    public EncapsulatedContent1 EncapsulatedContent { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_SwiSyQEcEeCQm6a_G2yO_w_-997515130")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [IsoId("_SwiSygEcEeCQm6a_G2yO_w_-1329278332")]
    [DisplayName("Signer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgnr")]
    #endif
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer1> Signer { get; init; } = new ValueList<Signer1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwiSygEcEeCQm6a_G2yO_w_-1329278332
    
    
    #nullable disable
    
}
