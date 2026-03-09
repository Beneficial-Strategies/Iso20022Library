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
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_PdBMwdp-Ed-ak6NoX_4Aeg_920823246")]
[DisplayName("Tax Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxParty2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Tax identification number of the debtor.
    /// </summary>
    [IsoId("_PdBMwtp-Ed-ak6NoX_4Aeg_920823361")]
    [DisplayName("Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxId")]
    #endif
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxIdentification { get; init; } 
    #else
    public System.String? TaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_PdBMw9p-Ed-ak6NoX_4Aeg_920823300")]
    [DisplayName("Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnId")]
    #endif
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationIdentification { get; init; } 
    #else
    public System.String? RegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_PdBMxNp-Ed-ak6NoX_4Aeg_920823277")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxType { get; init; } 
    #else
    public System.String? TaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the authorised tax paying party.
    /// </summary>
    [IsoId("_PdBMxdp-Ed-ak6NoX_4Aeg_-137944593")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxAuthorisation1? Authorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxAuthorisation1? Authorisation { get; init; } 
    #else
    public TaxAuthorisation1? Authorisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
