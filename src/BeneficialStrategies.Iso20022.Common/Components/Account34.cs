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
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_jHbk4XzhEeuEHsEB8Johfw")]
[DisplayName("Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Account34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Account34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Account34( PartyIdentification132 reqAccountServicer )
    {
        AccountServicer = reqAccountServicer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jeW3I3zhEeuEHsEB8Johfw")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_sMUs0HzhEeuEHsEB8Johfw")]
    [DisplayName("Account Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDsgnt")]
    #endif
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountDesignation { get; init; } 
    #else
    public System.String? AccountDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_sMUs0XzhEeuEHsEB8Johfw")]
    [DisplayName("Account Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNm")]
    #endif
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountName { get; init; } 
    #else
    public System.String? AccountName { get; set; } 
    #endif
    
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_jeW3JXzhEeuEHsEB8Johfw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification132 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification132 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification132 AccountServicer { get; init; } 
    #else
    public PartyIdentification132 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the nominee company that holds the assets at the transfer agent or International Central Securities Depository or Central Securities Depository on behalf of the party.
    /// </summary>
    [IsoId("_5jdtEXzhEeuEHsEB8Johfw")]
    [DisplayName("Registration Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAdr")]
    #endif
    [IsoXmlTag("RegnAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? RegistrationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? RegistrationAddress { get; init; } 
    #else
    public PostalAddress1? RegistrationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
