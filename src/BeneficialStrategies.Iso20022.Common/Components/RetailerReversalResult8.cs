// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal transaction results after a reversal request.
/// </summary>
[IsoId("_Sr6-UbYNEfCUZfsQO4rYeA")]
[DisplayName("Retailer Reversal Result8")]
public record RetailerReversalResult8
{
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    [IsoId("_Ss-uRbYNEfCUZfsQO4rYeA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    [IsoId("_Ss-uS7YNEfCUZfsQO4rYeA")]
    [DisplayName("Original Payment Transaction")]
    [IsoXmlTag("OrgnlPmtTx")]
    public PaymentTransaction183? OriginalPaymentTransaction { get; init; }

    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    [IsoId("_Ss-uUbYNEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];
}
