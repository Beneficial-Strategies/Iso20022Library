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
/// Details about a member of a loyalty programme.
/// </summary>
[IsoId("_qmMYMF_AEee_oqB7UglxLw")]
[DisplayName("Loyalty Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyMember1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the member of the loyalty programme.
    /// </summary>
    [IsoId("_2vYXkF_AEee_oqB7UglxLw")]
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
    /// Address of the loyalty member.
    /// </summary>
    [IsoId("_648N8F_AEee_oqB7UglxLw")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? Address { get; init; } 
    #else
    public Address1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the member of the loyalty programme.
    /// </summary>
    [IsoId("_F2jyEF_BEee_oqB7UglxLw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the loyalty programme member for the programme.
    /// </summary>
    [IsoId("_ObYS0F_BEee_oqB7UglxLw")]
    [DisplayName("Member Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbSts")]
    #endif
    [IsoXmlTag("MmbSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MemberStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MemberStatus { get; init; } 
    #else
    public System.String? MemberStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Expiration date of the loyalty programme.
    /// </summary>
    [IsoId("_Vb7kcF_BEee_oqB7UglxLw")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpirationDate { get; init; } 
    #else
    public System.DateOnly? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed in type of value for the loyalty programme.
    /// </summary>
    [IsoId("_hebtAF_BEee_oqB7UglxLw")]
    [DisplayName("Loyalty Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyVal")]
    #endif
    [IsoXmlTag("LltyVal")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? LoyaltyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoyaltyValue { get; init; } 
    #else
    public System.String? LoyaltyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Type of value used for the loyalty programme.
    /// </summary>
    [IsoId("_XAsGUF_CEee_oqB7UglxLw")]
    [DisplayName("Loyalty Value Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyValTp")]
    #endif
    [IsoXmlTag("LltyValTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyValueType1Code? LoyaltyValueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyValueType1Code? LoyaltyValueType { get; init; } 
    #else
    public LoyaltyValueType1Code? LoyaltyValueType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of loyalty value used for the programme.
    /// </summary>
    [IsoId("_eHCd8F_CEee_oqB7UglxLw")]
    [DisplayName("Other Loyalty Value Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrLltyValTp")]
    #endif
    [IsoXmlTag("OthrLltyValTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherLoyaltyValueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherLoyaltyValueType { get; init; } 
    #else
    public System.String? OtherLoyaltyValueType { get; set; } 
    #endif
    
    /// <summary>
    /// Value to be credited on the account of the loyalty programme member. Computed on the monetary part actually paid by the customer for the service.
    /// </summary>
    [IsoId("_wFzJkF_CEee_oqB7UglxLw")]
    [DisplayName("Value To Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValToCdt")]
    #endif
    [IsoXmlTag("ValToCdt")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? ValueToCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValueToCredit { get; init; } 
    #else
    public System.String? ValueToCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Value to be debited from the account of the loyalty programme member. Computed on the monetary part actually redeemed by the customer for the service.
    /// </summary>
    [IsoId("_6tZaYF_CEee_oqB7UglxLw")]
    [DisplayName("Value To Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValToDbt")]
    #endif
    [IsoXmlTag("ValToDbt")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? ValueToDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValueToDebit { get; init; } 
    #else
    public System.String? ValueToDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Value on the account of the loyalty programme member after credit (computation on actual payment in monetary value) and debit (redemption in loyalty value).
    /// </summary>
    [IsoId("_K1ebwF_EEee_oqB7UglxLw")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Balance { get; init; } 
    #else
    public System.String? Balance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
