// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Amount4.
/// </summary>
[IsoId("_SNLNYDH0Ee6BxvG014AZzQ")]
[DisplayName("Remittance Amount4")]
public record RemittanceAmount4
{
    /// <summary>
    /// Adjustment Amount And Reason.
    /// </summary>
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public ValueList<DocumentAdjustment1> AdjustmentAmountAndReason { get; init; } = [];

    /// <summary>
    /// Remittance Amount And Type.
    /// </summary>
    [DisplayName("Remittance Amount And Type")]
    [IsoXmlTag("RmtAmtAndTp")]
    public ValueList<DocumentAmount1> RemittanceAmountAndType { get; init; } = [];
}
