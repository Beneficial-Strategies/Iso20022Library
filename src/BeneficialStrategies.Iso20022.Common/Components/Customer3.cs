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
[IsoId("_q6pIUEB-EeeXpbqDpLawug")]
[DisplayName("Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Customer3
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
    [IsoId("_oI6qUBVjEei_7rtBiunN6A")]
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
    /// Name of the financial customer.
    /// </summary>
    [IsoId("_Cza7UEB_EeeXpbqDpLawug")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the financial customer.
    /// </summary>
    [IsoId("_HBTRAEB_EeeXpbqDpLawug")]
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
    /// Credentials of the financial customer.
    /// </summary>
    [IsoId("_DEsCwECFEeeXpbqDpLawug")]
    [DisplayName("Credentials")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdntls")]
    #endif
    [IsoXmlTag("Crdntls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Credentials1? Credentials { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Credentials1? Credentials { get; init; } 
    #else
    public Credentials1? Credentials { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the customer.
    /// </summary>
    [IsoId("_Dc28oBVkEei_7rtBiunN6A")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_K3F7MBqYEeqH1IQNpbVpEw")]
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
    
    
    #nullable disable
    
}
