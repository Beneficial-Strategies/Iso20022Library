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
[IsoId("__Q-MgXuxEeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionEnvironment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionEnvironment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionEnvironment3( Acquirer6 reqAcquirer,Organisation19 reqAcceptor,PaymentCard14 reqCard )
    {
        Acquirer = reqAcquirer;
        Acceptor = reqAcceptor;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer of the card transaction.
    /// </summary>
    [IsoId("__de-gXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Acquirer6 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Acquirer6 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer6 Acquirer { get; init; } 
    #else
    public Acquirer6 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the interconnected card scheme from which the response is coming.
    /// </summary>
    [IsoId("_Tj0ZkIPUEeSvn4rZUbUwhw")]
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
    /// Acceptor performing the card transaction.
    /// </summary>
    [IsoId("__de-g3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Acceptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptr")]
    #endif
    [IsoXmlTag("Accptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Organisation19 Acceptor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Organisation19 Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation19 Acceptor { get; init; } 
    #else
    public Organisation19 Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_g_fVkHuyEeS2Z_kGi7H1VQ")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? TerminalIdentification { get; init; } 
    #else
    public GenericIdentification32? TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("__de-h3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard14 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard14 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard14 Card { get; init; } 
    #else
    public PaymentCard14 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("__de-iXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? CustomerDevice { get; init; } 
    #else
    public CustomerDevice1? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("__de-i3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? Wallet { get; init; } 
    #else
    public CustomerDevice1? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("__de-jXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken4? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken4? PaymentToken { get; init; } 
    #else
    public CardPaymentToken4? PaymentToken { get; set; } 
    #endif
    
    
    #nullable disable
    
}
