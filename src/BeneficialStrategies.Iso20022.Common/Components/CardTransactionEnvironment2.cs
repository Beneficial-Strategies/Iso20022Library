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
/// Environment of the transaction.
/// </summary>
[IsoId("_ZeCrQXuPEeSVeNXcmBQ4hQ")]
[DisplayName("Card Transaction Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionEnvironment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionEnvironment2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionEnvironment2( System.String reqAcquirerIdentification,PaymentCard13 reqCard )
    {
        AcquirerIdentification = reqAcquirerIdentification;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer identification of the transaction.
    /// </summary>
    [IsoId("_JAOYgHuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AcquirerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AcquirerIdentification { get; init; } 
    #else
    public System.String AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the interconnected card scheme from which the response is coming.
    /// </summary>
    [IsoId("_S9U60HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Card Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSchmeId")]
    #endif
    [IsoXmlTag("CardSchmeId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSchemeIdentification { get; init; } 
    #else
    public System.String? CardSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the card acceptor performing the transaction.
    /// </summary>
    [IsoId("_Xixb8HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Acceptor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrId")]
    #endif
    [IsoXmlTag("AccptrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcceptorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcceptorIdentification { get; init; } 
    #else
    public System.String? AcceptorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_b8lU0HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TerminalIdentification { get; init; } 
    #else
    public System.String? TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_ZrJ6N3uPEeSVeNXcmBQ4hQ")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard13 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard13 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard13 Card { get; init; } 
    #else
    public PaymentCard13 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_ZrJ6PXuPEeSVeNXcmBQ4hQ")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken2? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken2? PaymentToken { get; init; } 
    #else
    public CardPaymentToken2? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_Yi5KQHuSEeSVeNXcmBQ4hQ")]
    [DisplayName("Shipping Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgAdr")]
    #endif
    [IsoXmlTag("ShppgAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress18? ShippingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress18? ShippingAddress { get; init; } 
    #else
    public PostalAddress18? ShippingAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
