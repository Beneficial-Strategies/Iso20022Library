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
/// Execution of a subscription order.
/// </summary>
[IsoId("_VUO3wtp-Ed-ak6NoX_4Aeg_-215103151")]
[DisplayName("Subscription Bulk Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionBulkExecution2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionBulkExecution2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionBulkExecution2( FinancialInstrument6 reqFinancialInstrumentDetails )
    {
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VUO3w9p-Ed-ak6NoX_4Aeg_-215102838")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfTrade { get; init; } 
    #else
    public string? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VUO3xNp-Ed-ak6NoX_4Aeg_-215103149")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VUO3xdp-Ed-ak6NoX_4Aeg_-215103073")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1? CancellationRight { get; init; } 
    #else
    public CancellationRight1? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VUO3xtp-Ed-ak6NoX_4Aeg_-215102812")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument6 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("_VUO3x9p-Ed-ak6NoX_4Aeg_-215102764")]
    [DisplayName("Individual Execution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvExctnDtls")]
    #endif
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<SubscriptionExecution3> IndividualExecutionDetails { get; init; } = new ValueList<SubscriptionExecution3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VUO3x9p-Ed-ak6NoX_4Aeg_-215102764
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VUO3yNp-Ed-ak6NoX_4Aeg_-215103134")]
    [DisplayName("Requested Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmCcy")]
    #endif
    [IsoXmlTag("ReqdSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedSettlementCurrency { get; init; } 
    #else
    public string? RequestedSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VUO3ydp-Ed-ak6NoX_4Aeg_-215103090")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VUO3ytp-Ed-ak6NoX_4Aeg_-215102742")]
    [DisplayName("Bulk Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkCshSttlmDtls")]
    #endif
    [IsoXmlTag("BlkCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction16? BulkCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction16? BulkCashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction16? BulkCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
