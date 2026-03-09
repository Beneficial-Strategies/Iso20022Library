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
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_vT7MmTbsEead9bDRE_1DAQ")]
[DisplayName("Subscription Bulk Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionBulkOrder5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionBulkOrder5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionBulkOrder5( FinancialInstrument57 reqFinancialInstrumentDetails )
    {
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_vsxKbTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_vsxKbzbsEead9bDRE_1DAQ")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("_vsxKcTbsEead9bDRE_1DAQ")]
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
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_vsxKczbsEead9bDRE_1DAQ")]
    [DisplayName("Expiry Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtTm")]
    #endif
    [IsoXmlTag("XpryDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpiryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_vsxKdTbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Future Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdFutrTradDt")]
    #endif
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedFutureTradeDate { get; init; } 
    #else
    public System.DateOnly? RequestedFutureTradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("_vsxKdzbsEead9bDRE_1DAQ")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    #else
    public CancellationRight1Choice_? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    [IsoId("_vsxKezbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument57 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Order to invest the investor&apos;s principal in an investment fund.
    /// </summary>
    [IsoId("_vsxKfTbsEead9bDRE_1DAQ")]
    [DisplayName("Individual Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvOrdrDtls")]
    #endif
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<SubscriptionOrder15> IndividualOrderDetails { get; init; } = new ValueList<SubscriptionOrder15>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _vsxKfTbsEead9bDRE_1DAQ
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_vsxKfzbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmCcy")]
    #endif
    [IsoXmlTag("ReqdSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedSettlementCurrency { get; init; } 
    #else
    public string? RequestedSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_vsxKgTbsEead9bDRE_1DAQ")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_vsxKgzbsEead9bDRE_1DAQ")]
    [DisplayName("Total Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSttlmAmt")]
    #endif
    [IsoXmlTag("TtlSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_vsxKhzbsEead9bDRE_1DAQ")]
    [DisplayName("Bulk Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkCshSttlmDtls")]
    #endif
    [IsoXmlTag("BlkCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction70? BulkCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction70? BulkCashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction70? BulkCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
