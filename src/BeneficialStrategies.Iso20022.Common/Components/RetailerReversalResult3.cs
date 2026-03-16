// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal transaction results after a Reversal request.
/// </summary>
[IsoId("_b6qjIS84Eeu125Ip9zFcsQ")]
[DisplayName("Retailer Reversal Result")]
public record RetailerReversalResult3
{
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    [IsoId("_cHNKUS84Eeu125Ip9zFcsQ")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    [IsoId("_cHNKUy84Eeu125Ip9zFcsQ")]
    [DisplayName("Original Payment Transaction")]
    [IsoXmlTag("OrgnlPmtTx")]
    public CardPaymentTransaction110? OriginalPaymentTransaction { get; init; }

    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    [IsoId("_cHNKVS84Eeu125Ip9zFcsQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
