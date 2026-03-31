// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Identification15.
/// </summary>
[IsoId("_0dCeKTEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Identification15")]
public record PaymentIdentification15
{
    /// <summary>
    /// Clearing System Reference.
    /// </summary>
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <summary>
    /// End To End Identification.
    /// </summary>
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <summary>
    /// First Agent.
    /// </summary>
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification8? FirstAgent { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }
}
