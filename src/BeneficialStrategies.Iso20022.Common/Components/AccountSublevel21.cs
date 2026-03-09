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
/// Provides detailed ownership information about the shareholding quantity to be disclosed,  or the shareholding quantity not to be disclosed and the shareholding quantity below threshold.
/// </summary>
[IsoId("_6J90MMAOEembi_x1QDJfxw")]
[DisplayName("Account Sublevel")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSublevel21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not disclosed.
    /// </summary>
    [IsoId("_EjvrcMAPEembi_x1QDJfxw")]
    [DisplayName("Non Disclosed Shareholding Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonDscldShrhldgQty")]
    #endif
    [IsoXmlTag("NonDscldShrhldgQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not reported as the quantity of shares owned by the shareholder is under the threshold limit.
    /// </summary>
    [IsoId("_M8FH0cJeEemAX8h_sVjY5g")]
    [DisplayName("Below Threshold Shareholding Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlwThrshldShrhldgQty")]
    #endif
    [IsoXmlTag("BlwThrshldShrhldgQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the account sub-levels and holdings.
    /// </summary>
    [IsoId("_KKnNUMAPEembi_x1QDJfxw")]
    [DisplayName("Disclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclsr")]
    #endif
    [IsoXmlTag("Dsclsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountSubLevel20? Disclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSubLevel20? Disclosure { get; init; } 
    #else
    public AccountSubLevel20? Disclosure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
