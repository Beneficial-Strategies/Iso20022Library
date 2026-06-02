// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification.
/// </summary>
[IsoId("_eyx9sRSDEfCR0f9NGJICbA")]
[DisplayName("Document Identification57")]
public record DocumentIdentification57
{
    /// <summary>
    /// Identification of the related buyer protection instruction document for which the status is provided.
    /// </summary>
    [IsoId("_iux5MRSDEfCR0f9NGJICbA")]
    [DisplayName("Buyer Protection Instruction Identification")]
    [IsoXmlTag("BuyrPrtcnInstrId")]
    public required IsoMax35Text BuyerProtectionInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the instruction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    [IsoId("_nysfAhSDEfCR0f9NGJICbA")]
    [DisplayName("Processor Instruction Identification")]
    [IsoXmlTag("PrcrInstrId")]
    public IsoMax35Text? ProcessorInstructionIdentification { get; init; }
}
