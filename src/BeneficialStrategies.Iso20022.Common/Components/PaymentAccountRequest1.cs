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
/// Data related to the account pointed by the payment card.
/// </summary>
[IsoId("_TIjQcNuIEeiB5uLfkg9ZJA")]
[DisplayName("Payment Account Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentAccountRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of cardholder account used for the transaction. By Default the code Default is taken into account.
    /// </summary>
    [IsoId("_f2VKoNuIEeiB5uLfkg9ZJA")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType3Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType3Code? AccountType { get; init; } 
    #else
    public CardAccountType3Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_kfpfINuIEeiB5uLfkg9ZJA")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an account (all types).
    /// </summary>
    [IsoId("_n-WaoNuIEeiB5uLfkg9ZJA")]
    [DisplayName("Account Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctRef")]
    #endif
    [IsoXmlTag("AcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountReference { get; init; } 
    #else
    public System.String? AccountReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
