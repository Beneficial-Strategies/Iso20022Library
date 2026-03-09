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
/// Payment terms and conditions related to a single invoice to be financed.
/// </summary>
[IsoId("_PyxaV9p-Ed-ak6NoX_4Aeg_-1837581386")]
[DisplayName("Payment Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInformation15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInformation15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInformation15( PaymentMethod4Code reqPaymentMethod )
    {
        PaymentMethod = reqPaymentMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Payment method that will be used for invoice payment to transfer the funds to the creditor.
    /// </summary>
    [IsoId("_Py7LUNp-Ed-ak6NoX_4Aeg_-1837581384")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentMethod4Code PaymentMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentMethod4Code PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod4Code PaymentMethod { get; init; } 
    #else
    public PaymentMethod4Code PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account used for payment settlement.
    /// </summary>
    [IsoId("_Py7LUdp-Ed-ak6NoX_4Aeg_-102369781")]
    [DisplayName("Payment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcct")]
    #endif
    [IsoXmlTag("PmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? PaymentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? PaymentAccount { get; init; } 
    #else
    public CashAccount7? PaymentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
