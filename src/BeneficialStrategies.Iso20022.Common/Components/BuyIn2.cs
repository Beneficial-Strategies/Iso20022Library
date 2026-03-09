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
/// Specifies elements related to the confirmation sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
[IsoId("_Uot1ldp-Ed-ak6NoX_4Aeg_1022669122")]
[DisplayName("Buy In")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyIn2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BuyIn2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyIn2( System.String reqBuyInIdentification,System.DateOnly reqDate )
    {
        BuyInIdentification = reqBuyInIdentification;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the reference of the BuyInNotification message.
    /// </summary>
    [IsoId("_Uot1ltp-Ed-ak6NoX_4Aeg_-1301593621")]
    [DisplayName("Buy In Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInNtfctnId")]
    #endif
    [IsoXmlTag("BuyInNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BuyInNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BuyInNotificationIdentification { get; init; } 
    #else
    public System.String? BuyInNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reference id of the buy in.
    /// </summary>
    [IsoId("_Uot1l9p-Ed-ak6NoX_4Aeg_1529026602")]
    [DisplayName("Buy In Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInId")]
    #endif
    [IsoXmlTag("BuyInId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BuyInIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BuyInIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BuyInIdentification { get; init; } 
    #else
    public System.String BuyInIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date at which the buy occured.
    /// </summary>
    [IsoId("_Uot1mNp-Ed-ak6NoX_4Aeg_1976267456")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the price of the buy-in.
    /// </summary>
    [IsoId("_Uo3mkNp-Ed-ak6NoX_4Aeg_346078375")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? Price { get; init; } 
    #else
    public Price4? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the elements related to the securities that the central counterparty had to buy in the context of the buy-in process.
    /// </summary>
    [IsoId("_Uo3mkdp-Ed-ak6NoX_4Aeg_-1107722371")]
    [DisplayName("Securities Buy In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBuyIn")]
    #endif
    [IsoXmlTag("SctiesBuyIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCompensation1? SecuritiesBuyIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCompensation1? SecuritiesBuyIn { get; init; } 
    #else
    public SecuritiesCompensation1? SecuritiesBuyIn { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the cash compensation required, in case the central counterparty could not buy the securities to cover the trade(s) that failed.
    /// </summary>
    [IsoId("_Uo3mktp-Ed-ak6NoX_4Aeg_1388271978")]
    [DisplayName("Required Cash Compensation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdCshCompstn")]
    #endif
    [IsoXmlTag("ReqrdCshCompstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCompensation1? RequiredCashCompensation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCompensation1? RequiredCashCompensation { get; init; } 
    #else
    public CashCompensation1? RequiredCashCompensation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
