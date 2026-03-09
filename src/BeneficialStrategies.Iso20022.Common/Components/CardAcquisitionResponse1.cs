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
/// Content of the Card Acquisition Response message.
/// </summary>
[IsoId("_eq2jANxZEeioifFt1dhnJA")]
[DisplayName("Card Acquisition Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAcquisitionResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardAcquisitionResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardAcquisitionResponse1( TransactionIdentifier1 reqPOITransactionIdentification )
    {
        POITransactionIdentification = reqPOITransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_faoksNxaEeioifFt1dhnJA")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of payment card.
    /// </summary>
    [IsoId("_ifQzUNxaEeioifFt1dhnJA")]
    [DisplayName("Payment Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtBrnd")]
    #endif
    [IsoXmlTag("PmtBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentBrand { get; init; } 
    #else
    public System.String? PaymentBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_lnOCwNxaEeioifFt1dhnJA")]
    [DisplayName("Customer Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrLang")]
    #endif
    [IsoXmlTag("CstmrLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? CustomerLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CustomerLanguage { get; init; } 
    #else
    public string? CustomerLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_YVTEQNxbEeioifFt1dhnJA")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount1? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_clbcsNxbEeioifFt1dhnJA")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
