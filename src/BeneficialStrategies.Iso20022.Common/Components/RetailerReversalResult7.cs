// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Retailer Reversal Result7.
/// </summary>
[IsoId("_3el4gZ9FEe-nbM0aSPcoiQ")]
[DisplayName("Retailer Reversal Result7")]
public record RetailerReversalResult7
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
    public PaymentTransaction165? OriginalPaymentTransaction { get; init; }

    /// <summary>
    /// POI Reconciliation Identification.
    /// </summary>
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }
}
