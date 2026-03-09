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
/// Data related to an account.
/// </summary>
[IsoId("_w9aBcO19Eei-V5h0ja04AA")]
[DisplayName("Payment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentAccount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of a Payment Account.
    /// </summary>
    [IsoId("_9cCsYO19Eei-V5h0ja04AA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of a Payment Account
    /// </summary>
    [IsoId("_Cmn64O1-Eei-V5h0ja04AA")]
    [DisplayName("Current Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurBal")]
    #endif
    [IsoXmlTag("CurBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CurrentBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CurrentBalance { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CurrentBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of Acquirer.
    /// </summary>
    [IsoId("_HMWv4O1-Eei-V5h0ja04AA")]
    [DisplayName("Payment Acquirer Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcqrrData")]
    #endif
    [IsoXmlTag("PmtAcqrrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer9? PaymentAcquirerData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer9? PaymentAcquirerData { get; init; } 
    #else
    public Acquirer9? PaymentAcquirerData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
