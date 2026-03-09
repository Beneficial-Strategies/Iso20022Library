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
/// Elements of identification of a batch management transaction.
/// </summary>
[IsoId("_A7J8gEBbEeepk8PtnyIgsg")]
[DisplayName("Batch Management Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BatchManagementInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BatchManagementInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BatchManagementInformation1( System.String reqBatchIdentification )
    {
        BatchIdentification = reqBatchIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the collection to which the batch belongs.
    /// ISO 8583:2003 bit 69-2
    /// </summary>
    [IsoId("_NBPkkEBbEeepk8PtnyIgsg")]
    [DisplayName("Collection Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ColltnId")]
    #endif
    [IsoXmlTag("ColltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollectionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollectionIdentification { get; init; } 
    #else
    public System.String? CollectionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the batch to which the message belongs.
    /// ISO 8583:2003 bit 69-2
    /// </summary>
    [IsoId("_QZUToEBbEeepk8PtnyIgsg")]
    [DisplayName("Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchId")]
    #endif
    [IsoXmlTag("BtchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BatchIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BatchIdentification { get; init; } 
    #else
    public System.String BatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number of the message inside the batch.
    /// ISO 8583:87/93 bit 71
    /// ISO 8583:2003 bit 68-2
    /// </summary>
    [IsoId("_aLfYUEBbEeepk8PtnyIgsg")]
    [DisplayName("Message Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgSeqNb")]
    #endif
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? MessageSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageSequenceNumber { get; init; } 
    #else
    public System.String? MessageSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the message to use for the computation of the checksum of the batch or collection of messages.
    /// </summary>
    [IsoId("_0gZPgEBbEeepk8PtnyIgsg")]
    [DisplayName("Message Checksum Input Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgChcksmInptVal")]
    #endif
    [IsoXmlTag("MsgChcksmInptVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? MessageChecksumInputValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageChecksumInputValue { get; init; } 
    #else
    public System.Byte[]? MessageChecksumInputValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
