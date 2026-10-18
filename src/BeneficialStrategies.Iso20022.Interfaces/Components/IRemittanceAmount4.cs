// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the amounts of the referred document.
/// </summary>
[IsoId("_SNLNYDH0Ee6BxvG014AZzQ")]
public interface IRemittanceAmount4 : IIsoComponent
{
    /// <summary>
    /// Type and amount of money for the referred document.
    /// </summary>
    [DisplayName("Remittance Amount And Type")]
    [IsoXmlTag("RmtAmtAndTp")]
    IEnumerable<IDocumentAmount1> RemittanceAmountAndType { get; }

    /// <summary>
    /// Specifies detailed information on the amount and reason of the adjustment.
    /// </summary>
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    IEnumerable<IDocumentAdjustment1> AdjustmentAmountAndReason { get; }
}
