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
[IsoId("_3CmvvzbsEead9bDRE_1DAQ")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction71
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction71 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction71( CashInOrOut7Choice_ reqCashInOrOut )
    {
        CashInOrOut = reqCashInOrOut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("_3a23czbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Or Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInOrOut")]
    #endif
    [IsoXmlTag("CshInOrOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashInOrOut7Choice_ CashInOrOut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashInOrOut7Choice_ CashInOrOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInOrOut7Choice_ CashInOrOut { get; init; } 
    #else
    public CashInOrOut7Choice_ CashInOrOut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
