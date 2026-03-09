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
/// Details of transaction for a file action.
/// </summary>
[IsoId("_34WCMVEDEee94_dUz-hvgw")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction98
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction98 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction98( TransactionIdentification10 reqTransactionIdentification,FileActionScope1Code reqFileActionScope,FileActionType1Code reqFileActionType,FileActionDetails1 reqFileActionDetails )
    {
        TransactionIdentification = reqTransactionIdentification;
        FileActionScope = reqFileActionScope;
        FileActionType = reqFileActionType;
        FileActionDetails = reqFileActionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_gDGuUt0oEeil7LQldntseg")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReason { get; init; } 
    #else
    public System.String? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_gDGuU90oEeil7LQldntseg")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_4DaCw1EDEee94_dUz-hvgw")]
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
    /// Scope of file action.
    /// </summary>
    [IsoId("_7gBBUd0mEeil7LQldntseg")]
    [DisplayName("File Action Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnScp")]
    #endif
    [IsoXmlTag("FileActnScp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FileActionScope1Code FileActionScope { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FileActionScope1Code FileActionScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionScope1Code FileActionScope { get; init; } 
    #else
    public FileActionScope1Code FileActionScope { get; set; } 
    #endif
    
    /// <summary>
    /// Type of file action.
    /// ISO 8583:87 bit 91
    /// </summary>
    [IsoId("_FNISAFEEEee94_dUz-hvgw")]
    [DisplayName("File Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnTp")]
    #endif
    [IsoXmlTag("FileActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FileActionType1Code FileActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FileActionType1Code FileActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionType1Code FileActionType { get; init; } 
    #else
    public FileActionType1Code FileActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Other file action type in free text.
    /// </summary>
    [IsoId("_4DaCs1EDEee94_dUz-hvgw")]
    [DisplayName("Other File Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFileActnTp")]
    #endif
    [IsoXmlTag("OthrFileActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFileActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFileActionType { get; init; } 
    #else
    public System.String? OtherFileActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("__AbpwFEEEee94_dUz-hvgw")]
    [DisplayName("File Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnDtls")]
    #endif
    [IsoXmlTag("FileActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FileActionDetails1 FileActionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FileActionDetails1 FileActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionDetails1 FileActionDetails { get; init; } 
    #else
    public FileActionDetails1 FileActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_F7fykvF8EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BeTCARqnEeqH1IQNpbVpEw")]
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
