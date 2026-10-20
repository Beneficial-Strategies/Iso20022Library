// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a related settlement instruction.
/// </summary>
[IsoId("_4FpMcd72Ee-NrtAAlrBEgQ")]
[DisplayName("Related Settlement Instruction4")]
public partial record RelatedSettlementInstruction4
{
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_4Kvu4972Ee-NrtAAlrBEgQ")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public Max35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction.
    /// </summary>
    [IsoId("_4Kvu5d72Ee-NrtAAlrBEgQ")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public Max35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the related settlement instruction assigned by the account holder.
    /// </summary>
    [IsoId("_4Kvu5972Ee-NrtAAlrBEgQ")]
    [DisplayName("Related Settlement Instruction Identification")]
    [IsoXmlTag("RltdSttlmInstrId")]
    public Max35Text? RelatedSettlementInstructionIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_BepXod8BEe-NrtAAlrBEgQ")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public UTIIdentifier? UniqueTransactionIdentifier { get; init; }
}
