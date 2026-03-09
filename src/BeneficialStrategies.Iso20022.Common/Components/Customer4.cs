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
/// Information related to a consumer or a company.
/// </summary>
[IsoId("_oDA8ivJjEeiJn9rM2Znz2w")]
[DisplayName("Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Customer4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of customer.
    /// </summary>
    [IsoId("_oDA8kPJjEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerType2Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerType2Code? Type { get; init; } 
    #else
    public CustomerType2Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Reference number provided by a cardholder or customer to card acceptor to facilitate communication and record keeping.  The value may be a reference number, code, or generic number.
    /// </summary>
    [IsoId("_oDA8kfJjEeiJn9rM2Znz2w")]
    [DisplayName("Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefNb")]
    #endif
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferenceNumber { get; init; } 
    #else
    public System.String? ReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the customer recognized by the taxation authority.
    /// </summary>
    [IsoId("_oDA8jfJjEeiJn9rM2Znz2w")]
    [DisplayName("Tax Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRegnId")]
    #endif
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TaxRegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxRegistrationIdentification { get; init; } 
    #else
    public System.String? TaxRegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contact at the company.
    /// </summary>
    [IsoId("_oDA8jvJjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdCtctCpny")]
    #endif
    [IsoXmlTag("AuthrsdCtctCpny")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AuthorisedContactCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisedContactCompany { get; init; } 
    #else
    public System.String? AuthorisedContactCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Corporate individual or company (cardholder or their company) to be contacted for authorised purchases.
    /// </summary>
    [IsoId("_oDA8jPJjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdCtctNm")]
    #endif
    [IsoXmlTag("AuthrsdCtctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AuthorisedContactName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisedContactName { get; init; } 
    #else
    public System.String? AuthorisedContactName { get; set; } 
    #endif
    
    /// <summary>
    /// Phone number of an individual or
    /// company contacted for company authorised purchases.
    /// </summary>
    [IsoId("_oDA8j_JjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdCtctPhneNb")]
    #endif
    [IsoXmlTag("AuthrsdCtctPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? AuthorisedContactPhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisedContactPhoneNumber { get; init; } 
    #else
    public System.String? AuthorisedContactPhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Very Important Person indicator. 
    /// </summary>
    [IsoId("_oDA8i_JjEeiJn9rM2Znz2w")]
    [DisplayName("VIP Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VIPInd")]
    #endif
    [IsoXmlTag("VIPInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? VIPIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VIPIndicator { get; init; } 
    #else
    public System.String? VIPIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Customer relationship identifier.
    /// </summary>
    [IsoId("_oDA8kvJjEeiJn9rM2Znz2w")]
    [DisplayName("Customer Relationship")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRltsh")]
    #endif
    [IsoXmlTag("CstmrRltsh")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CustomerRelationship { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerRelationship { get; init; } 
    #else
    public System.String? CustomerRelationship { get; set; } 
    #endif
    
    
    #nullable disable
    
}
