// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-protected sensitive data associated with the card or payment token performing the transaction.
/// </summary>
[IsoId("_CSCukWDWEfCoP_h9uwd39Q")]
[DisplayName("Card Data17")]
public record CardData17
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// </summary>
    [IsoId("_CU51UWDWEfCoP_h9uwd39Q")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public IsoMax19NumericText? PAN { get; init; }

    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// </summary>
    [IsoId("_CU51WWDWEfCoP_h9uwd39Q")]
    [DisplayName("Protected PAN")]
    [IsoXmlTag("PrtctdPAN")]
    public IsoTrueFalseIndicator? ProtectedPAN { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// </summary>
    [IsoId("_CU51W2DWEfCoP_h9uwd39Q")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_CU51Y2DWEfCoP_h9uwd39Q")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or payment token.
    /// </summary>
    [IsoId("_CU51a2DWEfCoP_h9uwd39Q")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoISOYearMonth? ExpiryDate { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC.
    /// </summary>
    [IsoId("_CU51c2DWEfCoP_h9uwd39Q")]
    [DisplayName("Track3")]
    [IsoXmlTag("Trck3")]
    public IsoMax104Text? Track3 { get; init; }

    /// <summary>
    /// Unique non-financial reference assigned to a given PAN.
    /// </summary>
    [IsoId("_CU51e2DWEfCoP_h9uwd39Q")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio.
    /// </summary>
    [IsoId("_CU51j2DWEfCoP_h9uwd39Q")]
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    public IsoMax19NumericText? PANAccountRange { get; init; }

    /// <summary>
    /// PAN reference identifier.
    /// </summary>
    [IsoId("_hNxDEWDaEfCoP_h9uwd39Q")]
    [DisplayName("PAN Reference Identifier")]
    [IsoXmlTag("PANRefIdr")]
    public IsoMax35Text? PANReferenceIdentifier { get; init; }

    /// <summary>
    /// Last four digits of the PAN.
    /// </summary>
    [IsoId("_CU51kWDWEfCoP_h9uwd39Q")]
    [DisplayName("PAN Four Last Digits")]
    [IsoXmlTag("PANFourLastDgts")]
    public IsoMax4NumericText? PANFourLastDigits { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_CU51k2DWEfCoP_h9uwd39Q")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Currency code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_CU51m2DWEfCoP_h9uwd39Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_CU51o2DWEfCoP_h9uwd39Q")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Subtype of card product.
    /// </summary>
    [IsoId("_CU51pWDWEfCoP_h9uwd39Q")]
    [DisplayName("Product Sub Type")]
    [IsoXmlTag("PdctSubTp")]
    public IsoMax35Text? ProductSubType { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_CU51p2DWEfCoP_h9uwd39Q")]
    [DisplayName("Portfolio Identifier")]
    [IsoXmlTag("PrtflIdr")]
    public IsoMax35Text? PortfolioIdentifier { get; init; }

    /// <summary>
    /// Brand of the card or transaction.
    /// </summary>
    [IsoId("_Ge2tR2DWEfCoP_h9uwd39Q")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// The account funding source applied to the transaction.
    /// </summary>
    [IsoId("_Ge_3MGDWEfCoP_h9uwd39Q")]
    [DisplayName("Account Funding Source")]
    [IsoXmlTag("AcctFndgSrc")]
    public IsoMax10Text? AccountFundingSource { get; init; }

    /// <summary>
    /// Classification or type of the card user, such as commercial, consumer.
    /// </summary>
    [IsoId("_Ge_3MWDWEfCoP_h9uwd39Q")]
    [DisplayName("Segment")]
    [IsoXmlTag("Sgmt")]
    public IsoMax10Text? Segment { get; init; }

    /// <summary>
    /// Switch that processed the transaction.
    /// </summary>
    [IsoId("_Ge_3MmDWEfCoP_h9uwd39Q")]
    [DisplayName("Scheme")]
    [IsoXmlTag("Schme")]
    public IsoMax35Text? Scheme { get; init; }

    /// <summary>
    /// Date of card was issued to cardholder.
    /// </summary>
    [IsoId("_Ge_3M2DWEfCoP_h9uwd39Q")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public IsoISOYearMonth? IssueDate { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_Ge_3NGDWEfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Ge_3NWDWEfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
