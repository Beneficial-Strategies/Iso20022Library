// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Retailer Reversal Result6.
/// </summary>
[IsoId("_5setsZO6Ee65Pr8tnKxNQA")]
[DisplayName("Retailer Reversal Result6")]
public record RetailerReversalResult6
{
    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];

    /// <summary>
    /// Original Payment Transaction.
    /// </summary>
    [DisplayName("Original Payment Transaction")]
    [IsoXmlTag("OrgnlPmtTx")]
    public CardPaymentTransaction136? OriginalPaymentTransaction { get; init; }

    /// <summary>
    /// POI Reconciliation Identification.
    /// </summary>
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }
}
