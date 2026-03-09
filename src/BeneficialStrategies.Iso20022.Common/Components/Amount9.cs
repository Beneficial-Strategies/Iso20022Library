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
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_aZH-NvS6Eeife6veM7daYw")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_aZH-OfS6Eeife6veM7daYw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CarRentalServiceType2Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CarRentalServiceType2Code? Type { get; init; } 
    #else
    public CarRentalServiceType2Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    [IsoId("_aZH-O_S6Eeife6veM7daYw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_aZH-OPS6Eeife6veM7daYw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    [IsoId("_aZH-OvS6Eeife6veM7daYw")]
    [DisplayName("Credit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInd")]
    #endif
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditIndicator { get; init; } 
    #else
    public System.String? CreditIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the customer was notified about additional amounts. 
    /// </summary>
    [IsoId("_aZH-N_S6Eeife6veM7daYw")]
    [DisplayName("Customer Notified Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrNtfdInd")]
    #endif
    [IsoXmlTag("CstmrNtfdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CustomerNotifiedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerNotifiedIndicator { get; init; } 
    #else
    public System.String? CustomerNotifiedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
