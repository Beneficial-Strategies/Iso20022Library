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
[IsoId("_4YmZIeLZEeWFtOV72FbX9w")]
[DisplayName("Equity")]
public partial record Equity3
{
    #nullable enable
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_4jwgQeLZEeWFtOV72FbX9w")]
    [DisplayName("Preference To Income")]
    [IsoXmlTag("PrefToIncm")]
    public required PreferenceToIncome5Choice_ PreferenceToIncome { get; init; } 
    
    /// <summary>
    /// Date/time at which the security will no longer exist, for example, redeemable preference shares.
    /// </summary>
    [IsoId("_4jwgQ-LZEeWFtOV72FbX9w")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MaturityDate { get; init; } 
    
    /// <summary>
    /// Nominal amount which is not paid yet.
    /// </summary>
    [IsoId("_4jwgReLZEeWFtOV72FbX9w")]
    [DisplayName("Non Paid Amount")]
    [IsoXmlTag("NonPdAmt")]
    public ActiveCurrencyAndAmount? NonPaidAmount { get; init; } 
    
    /// <summary>
    /// Nominal value of an equity security.
    /// </summary>
    [IsoId("_4jwgR-LZEeWFtOV72FbX9w")]
    [DisplayName("Par Value")]
    [IsoXmlTag("ParVal")]
    public ActiveCurrencyAndAmount? ParValue { get; init; } 
    
    /// <summary>
    /// Number of voting rights per share.
    /// </summary>
    [IsoId("_4jwgSeLZEeWFtOV72FbX9w")]
    [DisplayName("Voting Rights Per Share")]
    [IsoXmlTag("VtngRghtsPerShr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? VotingRightsPerShare { get; init; } 
    
    
    #nullable disable
    
}
