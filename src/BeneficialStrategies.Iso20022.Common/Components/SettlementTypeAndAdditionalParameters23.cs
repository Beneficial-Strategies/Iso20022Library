// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Type And Additional Parameters23.
/// </summary>
[IsoId("_uHXTcYVnEe-Pv9KR9bv9IA")]
[DisplayName("Settlement Type And Additional Parameters23")]
public record SettlementTypeAndAdditionalParameters23
{
    /// <summary>
    /// Client Collateral Instruction Identification.
    /// </summary>
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Client Triparty Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Nonce Identification.
    /// </summary>
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Reconciliation Indicator.
    /// </summary>
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; }

    /// <summary>
    /// Securities Movement Type.
    /// </summary>
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Triparty Agent Service Provider Collateral Instruction Identification.
    /// </summary>
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Triparty Agent Service Provider Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }
}
