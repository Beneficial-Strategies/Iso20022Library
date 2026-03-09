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
/// Identification of requested data set.
/// </summary>
[IsoId("_vpp_MXI2Ee299ZbWCkdR_w")]
[DisplayName("Data Set Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DataSetRequest4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetRequest4( DataSetIdentification10 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_vxCZkXI2Ee299ZbWCkdR_w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification10 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification10 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification10 Identification { get; init; } 
    #else
    public DataSetIdentification10 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_vxCZk3I2Ee299ZbWCkdR_w")]
    [DisplayName("POI Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIChllng")]
    #endif
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? POIChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? POIChallenge { get; init; } 
    #else
    public System.Byte[]? POIChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_vxCZlXI2Ee299ZbWCkdR_w")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_vxCZl3I2Ee299ZbWCkdR_w")]
    [DisplayName("Session Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SsnKey")]
    #endif
    [IsoXmlTag("SsnKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey17? SessionKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey17? SessionKey { get; init; } 
    #else
    public CryptographicKey17? SessionKey { get; set; } 
    #endif
    
    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_vxCZmXI2Ee299ZbWCkdR_w")]
    [DisplayName("Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnProof")]
    #endif
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? DelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationProof { get; init; } 
    #else
    public System.Byte[]? DelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_vxCZm3I2Ee299ZbWCkdR_w")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType34? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType34? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType34? ProtectedDelegationProof { get; set; } 
    #endif
    
    
    #nullable disable
    
}
