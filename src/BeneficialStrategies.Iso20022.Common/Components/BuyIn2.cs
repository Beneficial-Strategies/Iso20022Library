// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies elements related to the confirmation sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
[IsoId("_Uot1ldp-Ed-ak6NoX_4Aeg_1022669122")]
[DisplayName("Buy In")]
public partial record BuyIn2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reference of the BuyInNotification message.
    /// </summary>
    [IsoId("_Uot1ltp-Ed-ak6NoX_4Aeg_-1301593621")]
    [DisplayName("Buy In Notification Identification")]
    [IsoXmlTag("BuyInNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BuyInNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the reference id of the buy in.
    /// </summary>
    [IsoId("_Uot1l9p-Ed-ak6NoX_4Aeg_1529026602")]
    [DisplayName("Buy In Identification")]
    [IsoXmlTag("BuyInId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BuyInIdentification { get; init; } 
    
    /// <summary>
    /// Provides the date at which the buy occured.
    /// </summary>
    [IsoId("_Uot1mNp-Ed-ak6NoX_4Aeg_1976267456")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    /// <summary>
    /// Provides the price of the buy-in.
    /// </summary>
    [IsoId("_Uo3mkNp-Ed-ak6NoX_4Aeg_346078375")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price4? Price { get; init; } 
    
    /// <summary>
    /// Specifies the elements related to the securities that the central counterparty had to buy in the context of the buy-in process.
    /// </summary>
    [IsoId("_Uo3mkdp-Ed-ak6NoX_4Aeg_-1107722371")]
    [DisplayName("Securities Buy In")]
    [IsoXmlTag("SctiesBuyIn")]
    public SecuritiesCompensation1? SecuritiesBuyIn { get; init; } 
    
    /// <summary>
    /// Provides details about the cash compensation required, in case the central counterparty could not buy the securities to cover the trade(s) that failed.
    /// </summary>
    [IsoId("_Uo3mktp-Ed-ak6NoX_4Aeg_1388271978")]
    [DisplayName("Required Cash Compensation")]
    [IsoXmlTag("ReqrdCshCompstn")]
    public CashCompensation1? RequiredCashCompensation { get; init; } 
    
    
    #nullable disable
    
}
