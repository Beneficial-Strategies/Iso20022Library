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
/// Specifies the token data on which the signature is calculated by the LRCI client.
/// </summary>
[IsoId("_vvpoEM_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel Epayment Token Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelEpaymentTokenResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelEpaymentTokenResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelEpaymentTokenResponse1( System.Byte[] reqLRCITransactionIdentification,System.Byte[] reqServerSignature )
    {
        LRCITransactionIdentification = reqLRCITransactionIdentification;
        ServerSignature = reqServerSignature;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous transaction identification of the group of signed payment files.
    /// </summary>
    [IsoId("_q1xSkM_bEeWjSMe6YTKHlQ")]
    [DisplayName("LRCI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LRCITxId")]
    #endif
    [IsoXmlTag("LRCITxId")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Binary LRCITransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] LRCITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] LRCITransactionIdentification { get; init; } 
    #else
    public System.Byte[] LRCITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Individual record holding all data related to a payment file that is being used during the signature process.
    /// </summary>
    [IsoId("_ziCfIM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Payment Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInf")]
    #endif
    [IsoXmlTag("PmtInf")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<IsabelLRCIPaymentInformation1> PaymentInformation { get; init; } = new ValueList<IsabelLRCIPaymentInformation1>(){};
    
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of the original server challenge exchanged by the LRCI protocol during the signature process.
    /// </summary>
    [IsoId("_21vEgM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Server Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrSgntr")]
    #endif
    [IsoXmlTag("SvrSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1kBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1kBinary ServerSignature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] ServerSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] ServerSignature { get; init; } 
    #else
    public System.Byte[] ServerSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
