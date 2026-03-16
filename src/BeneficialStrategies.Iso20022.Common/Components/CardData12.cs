// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Data12.
/// </summary>
[IsoId("_piDdkXjLEe6YlIMyoxWMJA")]
[DisplayName("Card Data12")]
public partial record CardData12
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Card Sequence Number.
    /// </summary>
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; } 

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public IsoISOYearMonth? EffectiveDate { get; init; } 

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoISOYearMonth? ExpiryDate { get; init; } 

    /// <summary>
    /// PAN.
    /// </summary>
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public IsoMax19NumericText? PAN { get; init; } 

    /// <summary>
    /// PAN Account Range.
    /// </summary>
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    public IsoMax19NumericText? PANAccountRange { get; init; } 

    /// <summary>
    /// PAN Four Last Digits.
    /// </summary>
    [DisplayName("PAN Four Last Digits")]
    [IsoXmlTag("PANFourLastDgts")]
    public IsoMax4NumericText? PANFourLastDigits { get; init; } 

    /// <summary>
    /// Payment Account Reference.
    /// </summary>
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public IsoMax35Text? PaymentAccountReference { get; init; } 

    /// <summary>
    /// Portfolio Identifier.
    /// </summary>
    [DisplayName("Portfolio Identifier")]
    [IsoXmlTag("PrtflIdr")]
    public IsoMax35Text? PortfolioIdentifier { get; init; } 

    /// <summary>
    /// Product Sub Type.
    /// </summary>
    [DisplayName("Product Sub Type")]
    [IsoXmlTag("PdctSubTp")]
    public IsoMax35Text? ProductSubType { get; init; } 

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; } 

    /// <summary>
    /// Protected PAN.
    /// </summary>
    [DisplayName("Protected PAN")]
    [IsoXmlTag("PrtctdPAN")]
    public IsoTrueFalseIndicator? ProtectedPAN { get; init; } 

    /// <summary>
    /// Track3.
    /// </summary>
    [DisplayName("Track3")]
    [IsoXmlTag("Trck3")]
    public IsoMax104Text? Track3 { get; init; } 

    
    #nullable disable
    
}
