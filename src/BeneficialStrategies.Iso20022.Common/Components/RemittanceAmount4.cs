// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceAmount4"/>
[IsoId("_SNLNYDH0Ee6BxvG014AZzQ")]
[Description(@"Provides details on the amounts of the referred document.")]
[DisplayName("Remittance Amount4")]
public partial record RemittanceAmount4
{
    /// <inheritdoc cref="IRemittanceAmount4.AdjustmentAmountAndReason"/>
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public ValueList<DocumentAdjustment1> AdjustmentAmountAndReason { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount4.RemittanceAmountAndType"/>
    [DisplayName("Remittance Amount And Type")]
    [IsoXmlTag("RmtAmtAndTp")]
    public ValueList<DocumentAmount1> RemittanceAmountAndType { get; init; } = [];
}
