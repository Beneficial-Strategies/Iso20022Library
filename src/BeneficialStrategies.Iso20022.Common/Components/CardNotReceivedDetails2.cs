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
/// Details of a non-received card.
/// </summary>
[IsoId("_zw4wQcW4EeuhguwJmlgagQ")]
[DisplayName("Card Not Received Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardNotReceivedDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardNotReceivedDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardNotReceivedDetails2( System.DateOnly reqDateOfCardMailed,System.String reqMailedFromPostalCode )
    {
        DateOfCardMailed = reqDateOfCardMailed;
        MailedFromPostalCode = reqMailedFromPostalCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of card when mailed to the cardholder.
    /// </summary>
    [IsoId("_z1398cW4EeuhguwJmlgagQ")]
    [DisplayName("Date Of Card Mailed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfCardMld")]
    #endif
    [IsoXmlTag("DtOfCardMld")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateOfCardMailed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateOfCardMailed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateOfCardMailed { get; init; } 
    #else
    public System.DateOnly DateOfCardMailed { get; set; } 
    #endif
    
    /// <summary>
    /// Address where card was mailed to.
    /// </summary>
    [IsoId("_z13988W4EeuhguwJmlgagQ")]
    [DisplayName("Mailing Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngAdr")]
    #endif
    [IsoXmlTag("MlngAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? MailingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? MailingAddress { get; init; } 
    #else
    public Address2? MailingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unstructured mailing address where card was mailed to.
    /// </summary>
    [IsoId("_z1399cW4EeuhguwJmlgagQ")]
    [DisplayName("Mailing Address Unstructured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngAdrUstrd")]
    #endif
    [IsoXmlTag("MlngAdrUstrd")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? MailingAddressUnstructured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MailingAddressUnstructured { get; init; } 
    #else
    public System.String? MailingAddressUnstructured { get; set; } 
    #endif
    
    /// <summary>
    /// Postal code where the card was mailed from.
    /// </summary>
    [IsoId("_z13998W4EeuhguwJmlgagQ")]
    [DisplayName("Mailed From Postal Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MldFrPstlCd")]
    #endif
    [IsoXmlTag("MldFrPstlCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text MailedFromPostalCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MailedFromPostalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MailedFromPostalCode { get; init; } 
    #else
    public System.String MailedFromPostalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the beginning of validation of the card.
    /// </summary>
    [IsoId("_z139-cW4EeuhguwJmlgagQ")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidFrom { get; init; } 
    #else
    public System.DateOnly? ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether card provides a Card Security Code.
    /// True: Card provides a Card Security Code.
    /// False: Card does not provide a Card Security Code.
    /// </summary>
    [IsoId("_z139-8W4EeuhguwJmlgagQ")]
    [DisplayName("Card Security Code Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSctyCdInd")]
    #endif
    [IsoXmlTag("CardSctyCdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardSecurityCodeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSecurityCodeIndicator { get; init; } 
    #else
    public System.String? CardSecurityCodeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the security capabilities of the card.
    /// </summary>
    [IsoId("_z139_cW4EeuhguwJmlgagQ")]
    [DisplayName("Card Security Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSctyCpblty")]
    #endif
    [IsoXmlTag("CardSctyCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardSecurityCapability1? CardSecurityCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardSecurityCapability1? CardSecurityCapability { get; init; } 
    #else
    public CardSecurityCapability1? CardSecurityCapability { get; set; } 
    #endif
    
    
    #nullable disable
    
}
