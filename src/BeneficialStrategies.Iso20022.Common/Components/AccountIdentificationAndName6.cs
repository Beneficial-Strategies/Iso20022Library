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
/// Identification of the account expressed with a name and an account number.
/// </summary>
[IsoId("__rmBEVOWEeijdq8ilaxyOA")]
[DisplayName("Account Identification And Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountIdentificationAndName6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("__7qdY1OWEeijdq8ilaxyOA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of the customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_Fa6UUlOXEeijdq8ilaxyOA")]
    [DisplayName("IBAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IBAN")]
    #endif
    [IsoXmlTag("IBAN")]
    [IsoSimpleType(IsoSimpleType.IBAN2007Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoIBAN2007Identifier? IBAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IBAN { get; init; } 
    #else
    public System.String? IBAN { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the account, as assigned by the account servicer, using an identification scheme.
    /// </summary>
    [IsoId("_Fa6UU1OXEeijdq8ilaxyOA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericAccountIdentification1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericAccountIdentification1? Other { get; init; } 
    #else
    public GenericAccountIdentification1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
