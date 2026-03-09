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
/// Identifies the customer in a transfer of money.
/// </summary>
[IsoId("_M8YtEKd1EeuEcqP2FGAFaA")]
[DisplayName("Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Customer7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the customer assigned by a party.
    /// </summary>
    [IsoId("_NCiYYad1EeuEcqP2FGAFaA")]
    [DisplayName("Customer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrId")]
    #endif
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CustomerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerIdentification { get; init; } 
    #else
    public System.String? CustomerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the specific customer when multiple customers are associated with the same account.
    /// </summary>
    [IsoId("_wUjUgKd1EeuEcqP2FGAFaA")]
    [DisplayName("Customer Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDsgnt")]
    #endif
    [IsoXmlTag("CstmrDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? CustomerDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerDesignation { get; init; } 
    #else
    public System.String? CustomerDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial customer.
    /// </summary>
    [IsoId("_NCiYY6d1EeuEcqP2FGAFaA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName3? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName3? Name { get; init; } 
    #else
    public CardholderName3? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the financial customer.
    /// </summary>
    [IsoId("_NCiYZad1EeuEcqP2FGAFaA")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Detail contact information of the customer.
    /// </summary>
    [IsoId("_IOj7UCbSEeyhZIgCcGlTyA")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact6? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact6? ContactInformation { get; init; } 
    #else
    public Contact6? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Credentials of the financial customer.
    /// </summary>
    [IsoId("_NCiYZ6d1EeuEcqP2FGAFaA")]
    [DisplayName("Credentials")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdntls")]
    #endif
    [IsoXmlTag("Crdntls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Credentials2? Credentials { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Credentials2? Credentials { get; init; } 
    #else
    public Credentials2? Credentials { get; set; } 
    #endif
    
    /// <summary>
    /// Nationality information (ISO 3166-1 alpha-2 or alpha-3)
    /// </summary>
    [IsoId("_QmcMQCbSEeyhZIgCcGlTyA")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Nationality { get; init; } 
    #else
    public string? Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Country of Birth information (ISO 3166-1 alpha-2 or alpha-3)
    /// </summary>
    [IsoId("_XdeVgCbSEeyhZIgCcGlTyA")]
    [DisplayName("Country Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBirth")]
    #endif
    [IsoXmlTag("CtryOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? CountryOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfBirth { get; init; } 
    #else
    public string? CountryOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_NCiYa6d1EeuEcqP2FGAFaA")]
    [DisplayName("Date Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfBirth")]
    #endif
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfBirth { get; init; } 
    #else
    public System.DateOnly? DateOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_F3oz4MWxEeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData3? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData3? LocalData { get; init; } 
    #else
    public LocalData3? LocalData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the customer.
    /// </summary>
    [IsoId("_NCiYaad1EeuEcqP2FGAFaA")]
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
