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
/// Profile of the customer selected by an ATM.
/// </summary>
[IsoId("_Okqn8Yp3EeS3NqNpgnMh2w")]
[DisplayName("ATM Customer Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCustomerProfile2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_OxCQA4p3EeS3NqNpgnMh2w")]
    [DisplayName("Profile Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrflRef")]
    #endif
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProfileReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProfileReference { get; init; } 
    #else
    public System.String? ProfileReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_OxCQBYp3EeS3NqNpgnMh2w")]
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
    
    
    #nullable disable
    
}
