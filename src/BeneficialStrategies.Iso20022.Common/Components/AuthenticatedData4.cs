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
/// Message authentication code (MAC), computed on the data to protect with an encryption key.
/// </summary>
[IsoId("_lguGMGkIEeS7zPBpvm732w")]
[DisplayName("Authenticated Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthenticatedData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthenticatedData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthenticatedData4( AlgorithmIdentification15 reqMACAlgorithm,EncapsulatedContent3 reqEncapsulatedContent,System.Byte[] reqMAC )
    {
        MACAlgorithm = reqMACAlgorithm;
        EncapsulatedContent = reqEncapsulatedContent;
        MAC = reqMAC;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_lty44WkIEeS7zPBpvm732w")]
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
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    [IsoId("_lty442kIEeS7zPBpvm732w")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient4Choice_> Recipient { get; init; } = new ValueList<Recipient4Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _lty442kIEeS7zPBpvm732w
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_lty45WkIEeS7zPBpvm732w")]
    [DisplayName("MAC Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MACAlgo")]
    #endif
    [IsoXmlTag("MACAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification15 MACAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification15 MACAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification15 MACAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification15 MACAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_lty452kIEeS7zPBpvm732w")]
    [DisplayName("Encapsulated Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcpsltdCntt")]
    #endif
    [IsoXmlTag("NcpsltdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedContent3 EncapsulatedContent { get; init; } 
    #else
    public EncapsulatedContent3 EncapsulatedContent { get; set; } 
    #endif
    
    /// <summary>
    /// Message authentication code value.
    /// </summary>
    [IsoId("_lty46WkIEeS7zPBpvm732w")]
    [DisplayName("MAC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MAC")]
    #endif
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Binary MAC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] MAC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] MAC { get; init; } 
    #else
    public System.Byte[] MAC { get; set; } 
    #endif
    
    
    #nullable disable
    
}
