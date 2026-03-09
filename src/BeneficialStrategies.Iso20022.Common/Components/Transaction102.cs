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
/// Amendment transaction.
/// </summary>
[IsoId("_Mt51QVW5EeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction102
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction102 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction102( TransactionIdentification10 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
    /// </summary>
    [IsoId("_M6lmYVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Amended Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmddData")]
    #endif
    [IsoXmlTag("AmddData")]
    public ValueList<DetailedError1> AmendedData { get; init; } = new ValueList<DetailedError1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _M6lmYVW5EeeiG_nL4vgKnQ
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_M6lmZVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification10 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification10 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original message before correction/amendment.
    /// </summary>
    [IsoId("_M6lmY1W5EeeiG_nL4vgKnQ")]
    [DisplayName("Original Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsg")]
    #endif
    [IsoXmlTag("OrgnlMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? OriginalMessage { get; init; } 
    #else
    public System.Byte[]? OriginalMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Message amended.
    /// </summary>
    [IsoId("_M6lmaVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Message Amended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgAmdd")]
    #endif
    [IsoXmlTag("MsgAmdd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? MessageAmended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageAmended { get; init; } 
    #else
    public System.Byte[]? MessageAmended { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_aD1CwRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
