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
/// Data related to the cardholder.
/// </summary>
[IsoId("_OXgF0ds7Eee9e6xduATmQg")]
[DisplayName("Cardholder")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cardholder13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_OgaKMds7Eee9e6xduATmQg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification15? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification15? Identification { get; init; } 
    #else
    public PersonIdentification15? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_OgaKM9s7Eee9e6xduATmQg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax45Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_OgaKNds7Eee9e6xduATmQg")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_OgaKN9s7Eee9e6xduATmQg")]
    [DisplayName("Billing Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgAdr")]
    #endif
    [IsoXmlTag("BllgAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress22? BillingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress22? BillingAddress { get; init; } 
    #else
    public PostalAddress22? BillingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_OgaKOds7Eee9e6xduATmQg")]
    [DisplayName("Shipping Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgAdr")]
    #endif
    [IsoXmlTag("ShppgAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress22? ShippingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress22? ShippingAddress { get; init; } 
    #else
    public PostalAddress22? ShippingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [IsoId("_OgaKO9s7Eee9e6xduATmQg")]
    [DisplayName("Trip Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TripNb")]
    #endif
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripNumber { get; init; } 
    #else
    public System.String? TripNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [IsoId("_OgaKPds7Eee9e6xduATmQg")]
    [DisplayName("Vehicle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vhcl")]
    #endif
    [IsoXmlTag("Vhcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle1? Vehicle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle1? Vehicle { get; init; } 
    #else
    public Vehicle1? Vehicle { get; set; } 
    #endif
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_OgaKP9s7Eee9e6xduATmQg")]
    [DisplayName("Authentication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authntcn")]
    #endif
    [IsoXmlTag("Authntcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderAuthentication11? Authentication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderAuthentication11? Authentication { get; init; } 
    #else
    public CardholderAuthentication11? Authentication { get; set; } 
    #endif
    
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_OgaKQds7Eee9e6xduATmQg")]
    [DisplayName("Transaction Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxVrfctnRslt")]
    #endif
    [IsoXmlTag("TxVrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    #else
    public TransactionVerificationResult4? TransactionVerificationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_OgaKQ9s7Eee9e6xduATmQg")]
    [DisplayName("Personal Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnlData")]
    #endif
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PersonalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PersonalData { get; init; } 
    #else
    public System.String? PersonalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
