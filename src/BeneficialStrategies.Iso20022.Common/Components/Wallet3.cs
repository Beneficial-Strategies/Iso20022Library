// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Wallet3.
/// </summary>
[IsoId("_mtLxgW9wEe6DxcrvCrq6hQ")]
[DisplayName("Wallet3")]
public partial record Wallet3
{
    #nullable enable

    /// <summary>
    /// Account Age.
    /// </summary>
    [DisplayName("Account Age")]
    [IsoXmlTag("AcctAge")]
    public IsoMax5PositiveNumber? AccountAge { get; init; } 

    /// <summary>
    /// Account Country.
    /// </summary>
    [DisplayName("Account Country")]
    [IsoXmlTag("AcctCtry")]
    public ISOMax3ACountryCode? AccountCountry { get; init; } 

    /// <summary>
    /// Account Email Age.
    /// </summary>
    [DisplayName("Account Email Age")]
    [IsoXmlTag("AcctEmailAge")]
    public IsoMax5PositiveNumber? AccountEmailAge { get; init; } 

    /// <summary>
    /// Activity.
    /// </summary>
    [DisplayName("Activity")]
    [IsoXmlTag("Actvty")]
    public IsoMax10PositiveNumber? Activity { get; init; } 

    /// <summary>
    /// Activity Interval.
    /// </summary>
    [DisplayName("Activity Interval")]
    [IsoXmlTag("ActvtyIntrvl")]
    public Frequency12Code? ActivityInterval { get; init; } 

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Card Data Entry Mode.
    /// </summary>
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading9Code? CardDataEntryMode { get; init; } 

    /// <summary>
    /// Days Since Last Activity.
    /// </summary>
    [DisplayName("Days Since Last Activity")]
    [IsoXmlTag("DaysSncLastActvty")]
    public IsoMax5PositiveNumber? DaysSinceLastActivity { get; init; } 

    /// <summary>
    /// Last Wallet Change.
    /// </summary>
    [DisplayName("Last Wallet Change")]
    [IsoXmlTag("LastWlltChng")]
    public IsoMax5PositiveNumber? LastWalletChange { get; init; } 

    /// <summary>
    /// Other Card Data Entry Mode.
    /// </summary>
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 

    /// <summary>
    /// PAN Age.
    /// </summary>
    [DisplayName("PAN Age")]
    [IsoXmlTag("PANAge")]
    public IsoMax5PositiveNumber? PANAge { get; init; } 

    /// <summary>
    /// Provider.
    /// </summary>
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public PartyIdentification285? Provider { get; init; } 

    /// <summary>
    /// Provider Account Score.
    /// </summary>
    [DisplayName("Provider Account Score")]
    [IsoXmlTag("PrvdrAcctScore")]
    public IsoMax5PositiveNumber? ProviderAccountScore { get; init; } 

    /// <summary>
    /// Provider Device Score.
    /// </summary>
    [DisplayName("Provider Device Score")]
    [IsoXmlTag("PrvdrDvcScore")]
    public IsoMax5PositiveNumber? ProviderDeviceScore { get; init; } 

    /// <summary>
    /// Provider Phone Score.
    /// </summary>
    [DisplayName("Provider Phone Score")]
    [IsoXmlTag("PrvdrPhneScore")]
    public IsoMax5PositiveNumber? ProviderPhoneScore { get; init; } 

    /// <summary>
    /// Provider Risk Assessment.
    /// </summary>
    [DisplayName("Provider Risk Assessment")]
    [IsoXmlTag("PrvdrRskAssmnt")]
    public RiskAssessment1Code? ProviderRiskAssessment { get; init; } 

    /// <summary>
    /// Provider Risk Assessment Model Version.
    /// </summary>
    [DisplayName("Provider Risk Assessment Model Version")]
    [IsoXmlTag("PrvdrRskAssmntMdlVrsn")]
    public IsoMax35Text? ProviderRiskAssessmentModelVersion { get; init; } 

    /// <summary>
    /// Suspended Cards.
    /// </summary>
    [DisplayName("Suspended Cards")]
    [IsoXmlTag("SspdCrds")]
    public IsoMax5PositiveNumber? SuspendedCards { get; init; } 

    /// <summary>
    /// User Account Age.
    /// </summary>
    [DisplayName("User Account Age")]
    [IsoXmlTag("UsrAcctAge")]
    public IsoMax5PositiveNumber? UserAccountAge { get; init; } 

    
    #nullable disable
    
}
