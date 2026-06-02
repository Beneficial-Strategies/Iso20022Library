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
[IsoId("_UIQRQR7iEfCkq6-p7S3J1Q")]
[DisplayName("Card Data16")]
public record CardData16
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// </summary>
    [IsoId("_UOv60R7iEfCkq6-p7S3J1Q")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public IsoMax19NumericText? PAN { get; init; }

    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// </summary>
    [IsoId("_UOv62R7iEfCkq6-p7S3J1Q")]
    [DisplayName("Protected PAN")]
    [IsoXmlTag("PrtctdPAN")]
    public IsoTrueFalseIndicator? ProtectedPAN { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// </summary>
    [IsoId("_UOv62x7iEfCkq6-p7S3J1Q")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_UOv64x7iEfCkq6-p7S3J1Q")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or payment token.
    /// </summary>
    [IsoId("_UOv66x7iEfCkq6-p7S3J1Q")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoISOYearMonth? ExpiryDate { get; init; }

    /// <summary>
    /// Service attached to the card as defined in ISO 7813.
    /// </summary>
    [IsoId("_UOv68x7iEfCkq6-p7S3J1Q")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC.
    /// </summary>
    [IsoId("_UOv6-x7iEfCkq6-p7S3J1Q")]
    [DisplayName("Track1")]
    [IsoXmlTag("Trck1")]
    public IsoMax76Text? Track1 { get; init; }

    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC.
    /// </summary>
    [IsoId("_UOv7Ax7iEfCkq6-p7S3J1Q")]
    [DisplayName("Track2")]
    [IsoXmlTag("Trck2")]
    public Track2Data1Choice? Track2 { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC.
    /// </summary>
    [IsoId("_UOv7Cx7iEfCkq6-p7S3J1Q")]
    [DisplayName("Track3")]
    [IsoXmlTag("Trck3")]
    public IsoMax104Text? Track3 { get; init; }

    /// <summary>
    /// Unique non-financial reference assigned to a given PAN.
    /// </summary>
    [IsoId("_UOv7Ex7iEfCkq6-p7S3J1Q")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio.
    /// </summary>
    [IsoId("_UOv7Jx7iEfCkq6-p7S3J1Q")]
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    public IsoMax19NumericText? PANAccountRange { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_UOv7KR7iEfCkq6-p7S3J1Q")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Type or code of card product.
    /// </summary>
    [IsoId("_UOv7MR7iEfCkq6-p7S3J1Q")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Sub type or code of card product.
    /// </summary>
    [IsoId("_UOv7Mx7iEfCkq6-p7S3J1Q")]
    [DisplayName("Product Sub Type")]
    [IsoXmlTag("PdctSubTp")]
    public IsoMax35Text? ProductSubType { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_UOv7NR7iEfCkq6-p7S3J1Q")]
    [DisplayName("Portfolio Identifier")]
    [IsoXmlTag("PrtflIdr")]
    public IsoMax35Text? PortfolioIdentifier { get; init; }

    /// <summary>
    /// Brand of the card or transaction.
    /// </summary>
    [IsoId("_mmyCEB7iEfCkq6-p7S3J1Q")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Account funding source applied to the transaction.
    /// </summary>
    [IsoId("_ogywUB7lEfCkq6-p7S3J1Q")]
    [DisplayName("Account Funding Source")]
    [IsoXmlTag("AcctFndgSrc")]
    public IsoMax10Text? AccountFundingSource { get; init; }

    /// <summary>
    /// Classification or type of the card user, such as commercial, consumer.
    /// </summary>
    [IsoId("_krBGsB7nEfCkq6-p7S3J1Q")]
    [DisplayName("Segment")]
    [IsoXmlTag("Sgmt")]
    public IsoMax10Text? Segment { get; init; }

    /// <summary>
    /// Switch that processed the transaction.
    /// </summary>
    [IsoId("_KIYSUB7jEfCkq6-p7S3J1Q")]
    [DisplayName("Scheme")]
    [IsoXmlTag("Schme")]
    public IsoMax35Text? Scheme { get; init; }

    /// <summary>
    /// Date of card was issued to cardholder.
    /// </summary>
    [IsoId("_rVnaYCHwEfCkq6-p7S3J1Q")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public IsoISOYearMonth? IssueDate { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_0dvOQkVXEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_0dvOQ0VXEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
