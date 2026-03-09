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
/// Specifies corporate action dates.
/// </summary>
[IsoId("_ZHfZDx9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate81
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. 
    /// </summary>
    [IsoId("_ZHfZEx9REeuFz_FaCzCLgQ")]
    [DisplayName("Early Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyRspnDdln")]
    #endif
    [IsoXmlTag("EarlyRspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; } 
    #else
    public DateFormat49Choice_? EarlyResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_ZHfZGx9REeuFz_FaCzCLgQ")]
    [DisplayName("Cover Expiration Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverXprtnDdln")]
    #endif
    [IsoXmlTag("CoverXprtnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    #else
    public DateFormat43Choice_? CoverExpirationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_ZHfZIx9REeuFz_FaCzCLgQ")]
    [DisplayName("Protect Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDdln")]
    #endif
    [IsoXmlTag("PrtctDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat43Choice_? ProtectDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_? ProtectDeadline { get; init; } 
    #else
    public DateFormat43Choice_? ProtectDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_ZHfZKx9REeuFz_FaCzCLgQ")]
    [DisplayName("Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktDdln")]
    #endif
    [IsoXmlTag("MktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    #else
    public DateFormat49Choice_? MarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event.
    /// </summary>
    [IsoId("_ZHfZMx9REeuFz_FaCzCLgQ")]
    [DisplayName("Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDdln")]
    #endif
    [IsoXmlTag("RspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat54Choice_? ResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat54Choice_? ResponseDeadline { get; init; } 
    #else
    public DateFormat54Choice_? ResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_ZHfZOx9REeuFz_FaCzCLgQ")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ExpiryDate { get; init; } 
    #else
    public DateFormat49Choice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_ZHfZQx9REeuFz_FaCzCLgQ")]
    [DisplayName("Subscription Cost Debit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptCostDbtDt")]
    #endif
    [IsoXmlTag("SbcptCostDbtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; } 
    #else
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_ZHfZSx9REeuFz_FaCzCLgQ")]
    [DisplayName("Depository Cover Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstryCoverXprtnDt")]
    #endif
    [IsoXmlTag("DpstryCoverXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_ZHfZUx9REeuFz_FaCzCLgQ")]
    [DisplayName("Stock Lending Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockLndgDdln")]
    #endif
    [IsoXmlTag("StockLndgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? StockLendingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? StockLendingDeadline { get; init; } 
    #else
    public DateFormat49Choice_? StockLendingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    [IsoId("_ZHfZVR9REeuFz_FaCzCLgQ")]
    [DisplayName("Borrower Stock Lending Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwrStockLndgDdln")]
    #endif
    [IsoXmlTag("BrrwrStockLndgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BorrowerLendingDeadline6? BorrowerStockLendingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BorrowerLendingDeadline6? BorrowerStockLendingDeadline { get; init; } 
    #else
    public BorrowerLendingDeadline6? BorrowerStockLendingDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
