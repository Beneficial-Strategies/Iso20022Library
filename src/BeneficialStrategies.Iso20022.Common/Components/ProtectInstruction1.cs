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
/// Provides detailed information on protect and cover protect instructions.
/// </summary>
[IsoId("_TxoeQLpNEeilsanBGAzy4A")]
[DisplayName("Protect Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProtectInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProtectInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProtectInstruction1( ProtectTransactionType2Code reqTransactionType )
    {
        TransactionType = reqTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_vnWA4LpNEeilsanBGAzy4A")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProtectTransactionType2Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProtectTransactionType2Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectTransactionType2Code TransactionType { get; init; } 
    #else
    public ProtectTransactionType2Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference of the protect transaction assigned by the depository and used for cover protect validation.
    /// </summary>
    [IsoId("_55qlQLpNEeilsanBGAzy4A")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account which submitted the original protect instruction used for cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account.
    /// </summary>
    [IsoId("_-2GqELpNEeilsanBGAzy4A")]
    [DisplayName("Protect Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctSfkpgAcct")]
    #endif
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProtectSafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectSafekeepingAccount { get; init; } 
    #else
    public System.String? ProtectSafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the protect instruction was created and used for cover protect validation.
    /// </summary>
    [IsoId("_FfAQsLpOEeilsanBGAzy4A")]
    [DisplayName("Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDt")]
    #endif
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ProtectDate { get; init; } 
    #else
    public System.DateOnly? ProtectDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
