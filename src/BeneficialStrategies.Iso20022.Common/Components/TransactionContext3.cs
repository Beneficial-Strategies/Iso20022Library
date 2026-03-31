// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction
/// </summary>
[IsoId("_iMrMUSehEeiTrZHuJ0M1-Q")]
[DisplayName("Transaction Context")]
public record TransactionContext3
{
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction.
    /// ISO 8583:87 bit 18, ISO 8583:93 bit 18 &amp; 26, ISO 8583:2003 bit 26
    /// ISO 18245
    /// </summary>
    [IsoId("_w_ElwOwGEeiMkKo2clXHdQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_bJBIoGzgEemD24gVaMSpeA")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Card programme or brand related to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    [IsoId("_iZeSNyehEeiTrZHuJ0M1-Q")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public CardProgrammeMode1? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_iZeSOSehEeiTrZHuJ0M1-Q")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService2? SettlementService { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_iZeSOyehEeiTrZHuJ0M1-Q")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }
}
