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
[IsoId("_DabH0YgqEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction158
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction158 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction158( FileActionDetails2 reqFileActionDetails )
    {
        FileActionDetails = reqFileActionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Dfd_4YgqEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_Dfd_44gqEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_Dfd_5YgqEeu8-LhY4KPfWg")]
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
    
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("_coNuESxOEeyg-aG5nXcnfg")]
    [DisplayName("File Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileActnDtls")]
    #endif
    [IsoXmlTag("FileActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FileActionDetails2 FileActionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FileActionDetails2 FileActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionDetails2 FileActionDetails { get; init; } 
    #else
    public FileActionDetails2 FileActionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
