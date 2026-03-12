// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument which represents a title of ownership in a company, ie, the shareholder is entitled to a part of the company&apos;s profit - usually by payment of a dividend - and to voting rights, if any. Each company issues generally different classes of shares, eg, ordinary or common shares, which have no guaranteed amount of dividend but carry voting rights, or preferred shares, which receive dividends before ordinary shares but have no voting right.
/// </summary>
[IsoId("_Trn7Odp-Ed-ak6NoX_4Aeg_1255525531")]
[DisplayName("Equity")]
public partial record Equity1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_Trn7Otp-Ed-ak6NoX_4Aeg_-1622516641")]
    [DisplayName("Preference To Income")]
    [IsoXmlTag("PrefToIncm")]
    public required PreferenceToIncome1Code PreferenceToIncome { get; init; } 
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_Trn7O9p-Ed-ak6NoX_4Aeg_1861986259")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus1Code? PaymentStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    [IsoId("_TrxFINp-Ed-ak6NoX_4Aeg_1866604916")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    
    /// <summary>
    /// Date/time at which the security will no longer exist, for example, redeemable preference shares.
    /// </summary>
    [IsoId("_TrxFIdp-Ed-ak6NoX_4Aeg_1886922279")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MaturityDate { get; init; } 
    
    /// <summary>
    /// Nominal amount which is not paid yet.
    /// </summary>
    [IsoId("_TrxFItp-Ed-ak6NoX_4Aeg_1902621286")]
    [DisplayName("Non Paid Amount")]
    [IsoXmlTag("NonPdAmt")]
    public ActiveCurrencyAndAmount? NonPaidAmount { get; init; } 
    
    /// <summary>
    /// Nominal value of an equity security.
    /// </summary>
    [IsoId("_TrxFI9p-Ed-ak6NoX_4Aeg_1916473047")]
    [DisplayName("Par Value")]
    [IsoXmlTag("ParVal")]
    public ActiveCurrencyAndAmount? ParValue { get; init; } 
    
    /// <summary>
    /// Number of voting rights per share.
    /// </summary>
    [IsoId("_TrxFJNp-Ed-ak6NoX_4Aeg_1921092172")]
    [DisplayName("Voting Rights Per Share")]
    [IsoXmlTag("VtngRghtsPerShr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? VotingRightsPerShare { get; init; } 
    
    
    #nullable disable
    
}
