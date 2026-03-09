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
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_PyBzcdp-Ed-ak6NoX_4Aeg_-372042206")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("_PyBzctp-Ed-ak6NoX_4Aeg_-372041233")]
    [DisplayName("Cash In Or Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInOrOut")]
    #endif
    [IsoXmlTag("CshInOrOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInOrOut5Choice_? CashInOrOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInOrOut5Choice_? CashInOrOut { get; init; } 
    #else
    public CashInOrOut5Choice_? CashInOrOut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
