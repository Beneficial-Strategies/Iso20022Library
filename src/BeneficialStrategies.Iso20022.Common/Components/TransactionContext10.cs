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
[IsoId("_K4fNUcVeEeuips4fuphvoQ")]
[DisplayName("Transaction Context")]
public record TransactionContext10
{
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_K9540cVeEeuips4fuphvoQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public CardProgrammeMode3? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_UkLPgMVeEeuips4fuphvoQ")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_6HDeMcpEEeuuJ571wNLKkA")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService4? SettlementService { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_BagdscpFEeuuJ571wNLKkA")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }

    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    [IsoId("_VLKJccV-Eeua2vd9tJAtHg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
