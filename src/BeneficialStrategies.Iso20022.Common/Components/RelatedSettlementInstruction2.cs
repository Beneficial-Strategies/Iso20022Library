// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Settlement Instruction2.
/// </summary>
[IsoId("_kTlKUYYZEe-haozGYc1X7Q")]
[DisplayName("Related Settlement Instruction2")]
public partial record RelatedSettlementInstruction2
{
    #nullable enable

    /// <summary>
    /// Proceeds Quantity Breakdown.
    /// </summary>
    [DisplayName("Proceeds Quantity Breakdown")]
    [IsoXmlTag("PrcdsQtyBrkdwn")]
    public ProceedsQuantityBreakdown1? ProceedsQuantityBreakdown { get; init; } 

    /// <summary>
    /// Related Settlement Instruction Identification.
    /// </summary>
    [DisplayName("Related Settlement Instruction Identification")]
    [IsoXmlTag("RltdSttlmInstrId")]
    public required IsoMax35Text RelatedSettlementInstructionIdentification { get; init; } 

    /// <summary>
    /// Related Settlement Quantity.
    /// </summary>
    [DisplayName("Related Settlement Quantity")]
    [IsoXmlTag("RltdSttlmQty")]
    public FinancialInstrumentQuantity18Choice_? RelatedSettlementQuantity { get; init; } 

    /// <summary>
    /// Transfer Of Proceeds Type Indicator.
    /// </summary>
    [DisplayName("Transfer Of Proceeds Type Indicator")]
    [IsoXmlTag("TrfOfPrcdsTpInd")]
    public TransferOfProceedsType1Code? TransferOfProceedsTypeIndicator { get; init; } 

    
    #nullable disable
    
}
