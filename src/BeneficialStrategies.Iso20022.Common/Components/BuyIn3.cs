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
/// Specifies elements related to the response sent by the clearing member to the central counterparty in the context of the buy in process.
/// </summary>
[IsoId("_Uo3mk9p-Ed-ak6NoX_4Aeg_392375521")]
[DisplayName("Buy In")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyIn3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BuyIn3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyIn3( System.String reqBuyInNotificationIdentification,System.String reqRequestForDelayIndicator,System.UInt64 reqNumberOfDays,FinancialInstrumentQuantity1Choice_ reqInitialQuantity,FinancialInstrumentQuantity1Choice_ reqCoveredQuantity,FinancialInstrumentQuantity1Choice_ reqUncoveredQuantity )
    {
        BuyInNotificationIdentification = reqBuyInNotificationIdentification;
        RequestForDelayIndicator = reqRequestForDelayIndicator;
        NumberOfDays = reqNumberOfDays;
        InitialQuantity = reqInitialQuantity;
        CoveredQuantity = reqCoveredQuantity;
        UncoveredQuantity = reqUncoveredQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the reference of the BuyInNotification message.
    /// </summary>
    [IsoId("_Uo3mlNp-Ed-ak6NoX_4Aeg_903405859")]
    [DisplayName("Buy In Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInNtfctnId")]
    #endif
    [IsoXmlTag("BuyInNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BuyInNotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BuyInNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BuyInNotificationIdentification { get; init; } 
    #else
    public System.String BuyInNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specific continuous net settlement case where the central counterparty can call for buy-in at a date anterior to &quot;theoretical&quot; buy-in date, the clearing member may request a delay.
    /// </summary>
    [IsoId("_Uo3mldp-Ed-ak6NoX_4Aeg_-1794174189")]
    [DisplayName("Request For Delay Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForDelyInd")]
    #endif
    [IsoXmlTag("ReqForDelyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator RequestForDelayIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestForDelayIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestForDelayIndicator { get; init; } 
    #else
    public System.String RequestForDelayIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days associated to the request for delay.
    /// </summary>
    [IsoId("_Uo3mltp-Ed-ak6NoX_4Aeg_755179045")]
    [DisplayName("Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDays")]
    #endif
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDays { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDays { get; init; } 
    #else
    public System.UInt64 NumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Buy in quantity called initially by the central counterparty.
    /// </summary>
    [IsoId("_Uo3ml9p-Ed-ak6NoX_4Aeg_-1486972163")]
    [DisplayName("Initial Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlQty")]
    #endif
    [IsoXmlTag("InitlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ InitialQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ InitialQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ InitialQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ InitialQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity amount covered by the clearing member after notification.
    /// </summary>
    [IsoId("_Uo3mmNp-Ed-ak6NoX_4Aeg_-1479836456")]
    [DisplayName("Covered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvrdQty")]
    #endif
    [IsoXmlTag("CvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ CoveredQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ CoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ CoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ CoveredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity amount non covered by the clearing member after notification (this is, new buy in amount to be executed).
    /// </summary>
    [IsoId("_Uo3mmdp-Ed-ak6NoX_4Aeg_-657470426")]
    [DisplayName("Uncovered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UcvrdQty")]
    #endif
    [IsoXmlTag("UcvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ UncoveredQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ UncoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ UncoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ UncoveredQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
