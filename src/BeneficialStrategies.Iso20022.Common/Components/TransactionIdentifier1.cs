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
/// Identification of the transaction in an unambiguous way.
/// </summary>
[IsoId("_TFsqdwEcEeCQm6a_G2yO_w_-629860519")]
[DisplayName("Transaction Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionIdentifier1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionIdentifier1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionIdentifier1( System.DateTime reqTransactionDateTime,System.String reqTransactionReference )
    {
        TransactionDateTime = reqTransactionDateTime;
        TransactionReference = reqTransactionReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TFsqeAEcEeCQm6a_G2yO_w_-1727684501")]
    [DisplayName("Transaction Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtTm")]
    #endif
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransactionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TransactionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransactionDateTime { get; init; } 
    #else
    public System.DateTime TransactionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction that has to be unique for a time period.
    /// </summary>
    [IsoId("_TFsqeQEcEeCQm6a_G2yO_w_-1113655904")]
    [DisplayName("Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRef")]
    #endif
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionReference { get; init; } 
    #else
    public System.String TransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
