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
[IsoId("_CPQ1PTbtEead9bDRE_1DAQ")]
[DisplayName("Subscription Multiple Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionMultipleOrder6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionMultipleOrder6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionMultipleOrder6( InvestmentAccount58 reqInvestmentAccountDetails )
    {
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_Cnz4HTbtEead9bDRE_1DAQ")]
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
    [IsoId("_Cnz4HzbtEead9bDRE_1DAQ")]
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
    [IsoId("_Cnz4ITbtEead9bDRE_1DAQ")]
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
    [IsoId("_Cnz4IzbtEead9bDRE_1DAQ")]
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
    /// Future date at which the investor requests the order to be executed. The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_Cnz4JTbtEead9bDRE_1DAQ")]
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
    [IsoId("_Cnz4JzbtEead9bDRE_1DAQ")]
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
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("_Cnz4KzbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount58 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_Cnz4LTbtEead9bDRE_1DAQ")]
    [DisplayName("Beneficiary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryDtls")]
    #endif
    [IsoXmlTag("BnfcryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson31? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson31? BeneficiaryDetails { get; init; } 
    #else
    public IndividualPerson31? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Order to invest the investor&apos;s principal in an investment fund.
    /// </summary>
    [IsoId("_Cnz4LzbtEead9bDRE_1DAQ")]
    [DisplayName("Individual Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvOrdrDtls")]
    #endif
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<SubscriptionOrder14> IndividualOrderDetails { get; init; } = new ValueList<SubscriptionOrder14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Cnz4LzbtEead9bDRE_1DAQ
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Cnz4NTbtEead9bDRE_1DAQ")]
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
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_Cnz4MTbtEead9bDRE_1DAQ")]
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
    
    
    #nullable disable
    
}
