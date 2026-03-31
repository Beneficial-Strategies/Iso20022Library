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
[IsoId("_oefNAC2sEeuVt5XRmyhHiA")]
[DisplayName("Related Settlement Instruction")]
public record RelatedSettlementInstruction1
{
    /// <summary>
    /// Unambiguous identification of the related settlement instruction assigned by the account holder.
    /// </summary>
    [IsoId("_cx_1YNvWEeqmdMJWobugpw")]
    [DisplayName("Related Settlement Instruction Identification")]
    [IsoXmlTag("RltdSttlmInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RelatedSettlementInstructionIdentification { get; init; }

    /// <summary>
    /// Quantity of securities for which the market claim has been raised.
    /// </summary>
    [IsoId("_Fr_pAC2tEeuVt5XRmyhHiA")]
    [DisplayName("Related Settlement Quantity")]
    [IsoXmlTag("RltdSttlmQty")]
    public FinancialInstrumentQuantity18Choice_? RelatedSettlementQuantity { get; init; }
}
