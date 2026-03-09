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
/// Specifies the detailed parameters a service to be billed.
/// </summary>
[IsoId("_6PgXxJqlEeGSON8vddiWzQ_126693803")]
[DisplayName("Billing Service Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServiceParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServiceParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServiceParameters2( BillingServiceIdentification2 reqBankService,AmountAndDirection34 reqServiceChargeAmount )
    {
        BankService = reqBankService;
        ServiceChargeAmount = reqServiceChargeAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the details to fully identify the bank service.
    /// </summary>
    [IsoId("_6PgXxZqlEeGSON8vddiWzQ_-1989872304")]
    [DisplayName("Bank Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkSvc")]
    #endif
    [IsoXmlTag("BkSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingServiceIdentification2 BankService { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingServiceIdentification2 BankService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceIdentification2 BankService { get; init; } 
    #else
    public BillingServiceIdentification2 BankService { get; set; } 
    #endif
    
    /// <summary>
    /// Count or number of items (volume) involved in the charge.
    /// </summary>
    [IsoId("_6PgXxpqlEeGSON8vddiWzQ_-424116921")]
    [DisplayName("Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vol")]
    #endif
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Volume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Volume { get; init; } 
    #else
    public System.UInt64? Volume { get; set; } 
    #endif
    
    /// <summary>
    /// Price per item or unit used to calculate the charge expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PgXx5qlEeGSON8vddiWzQ_-1110935494")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? UnitPrice { get; init; } 
    #else
    public AmountAndDirection34? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the calculated charge expressed in the pricing currency, exclusive of any tax.
    /// </summary>
    [IsoId("_6PphsJqlEeGSON8vddiWzQ_534331941")]
    [DisplayName("Service Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcChrgAmt")]
    #endif
    [IsoXmlTag("SvcChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 ServiceChargeAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 ServiceChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 ServiceChargeAmount { get; init; } 
    #else
    public AmountAndDirection34 ServiceChargeAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
