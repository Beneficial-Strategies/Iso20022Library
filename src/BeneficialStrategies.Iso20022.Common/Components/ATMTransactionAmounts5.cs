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
/// Deposit limits for the account.
/// </summary>
[IsoId("_VLidYYq7EeSHjtO_wHA7PQ")]
[DisplayName("ATM Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransactionAmounts5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// True if limits may be displayed on the ATM to the customer.
    /// </summary>
    [IsoId("_VYWxYYq7EeSHjtO_wHA7PQ")]
    [DisplayName("Display Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispFlg")]
    #endif
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisplayFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisplayFlag { get; init; } 
    #else
    public System.String? DisplayFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount allowed for deposit on the account.
    /// </summary>
    [IsoId("_VYWxY4q7EeSHjtO_wHA7PQ")]
    [DisplayName("Maximum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmt")]
    #endif
    [IsoXmlTag("MaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
