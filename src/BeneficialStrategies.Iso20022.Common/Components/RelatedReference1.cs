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
/// Reference of the message previously received and for which the delivery status is notified.
/// </summary>
[IsoId("_rrrBUQ2zEeWH49U6bkyMaA")]
[DisplayName("Related Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelatedReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier assigned by the local application.
    /// </summary>
    [IsoId("_JFLwQRJaEeWg-NN-FmovgQ")]
    [DisplayName("Transaction Unique Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxUnqIdr")]
    #endif
    [IsoXmlTag("TxUnqIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? TransactionUniqueIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionUniqueIdentifier { get; init; } 
    #else
    public System.String? TransactionUniqueIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Message reference assigned by the original message sender.
    /// </summary>
    [IsoId("_F5zZYRJaEeWg-NN-FmovgQ")]
    [DisplayName("Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRef")]
    #endif
    [IsoXmlTag("MsgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReference { get; init; } 
    #else
    public System.String? MessageReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
