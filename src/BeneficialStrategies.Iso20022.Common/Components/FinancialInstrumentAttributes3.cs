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
/// Description of the financial instrument.
/// </summary>
[IsoId("_Tx4UNdp-Ed-ak6NoX_4Aeg_-800922818")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributes3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributes3( SecurityIdentification11 reqSecurityIdentification,DateFormat5Choice_ reqExpiryDate,DateFormat5Choice_ reqPostingDate )
    {
        SecurityIdentification = reqSecurityIdentification;
        ExpiryDate = reqExpiryDate;
        PostingDate = reqPostingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_Tx4UNtp-Ed-ak6NoX_4Aeg_-800922446")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_Tx4UN9p-Ed-ak6NoX_4Aeg_-299452126")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Quantity { get; init; } 
    #else
    public System.UInt64? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_Tx4UONp-Ed-ak6NoX_4Aeg_-1617519156")]
    [DisplayName("Renounceable Entitlement Status Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RnncblEntitlmntStsTp")]
    #endif
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; } 
    #else
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_TyCFMNp-Ed-ak6NoX_4Aeg_-831602303")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType3Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType3Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType3Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_TyCFMdp-Ed-ak6NoX_4Aeg_-2130665569")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtSctiesToUndrlygRatio")]
    #endif
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; } 
    #else
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; set; } 
    #endif
    
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_TyCFMtp-Ed-ak6NoX_4Aeg_564112779")]
    [DisplayName("Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPric")]
    #endif
    [IsoXmlTag("MktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountPrice2? MarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPrice2? MarketPrice { get; init; } 
    #else
    public AmountPrice2? MarketPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TyCFM9p-Ed-ak6NoX_4Aeg_-1352785741")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat5Choice_ ExpiryDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat5Choice_ ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat5Choice_ ExpiryDate { get; init; } 
    #else
    public DateFormat5Choice_ ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_TyCFNNp-Ed-ak6NoX_4Aeg_-1338012503")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat5Choice_ PostingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat5Choice_ PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat5Choice_ PostingDate { get; init; } 
    #else
    public DateFormat5Choice_ PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_TyCFNdp-Ed-ak6NoX_4Aeg_-1071910140")]
    [DisplayName("Trading Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPrd")]
    #endif
    [IsoXmlTag("TradgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? TradingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? TradingPeriod { get; init; } 
    #else
    public Period3? TradingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_TyCFNtp-Ed-ak6NoX_4Aeg_172257252")]
    [DisplayName("Uninstructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UinstdBal")]
    #endif
    [IsoXmlTag("UinstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? UninstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_TyCFN9p-Ed-ak6NoX_4Aeg_-824815101")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? InstructedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
