// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sale context in which the transaction is performed.
/// </summary>
[IsoId("_SwsDzAEcEeCQm6a_G2yO_w_1953670809")]
[DisplayName("Sale Context")]
public record SaleContext1
{
    /// <summary>
    /// Identification of the sale terminal (electronic cash register) or the sale system.
    /// </summary>
    [IsoId("_SwsDzQEcEeCQm6a_G2yO_w_-1301262192")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_SwsDzgEcEeCQm6a_G2yO_w_-1321065836")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_Sw1NsAEcEeCQm6a_G2yO_w_-1796156354")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_Sw1NsQEcEeCQm6a_G2yO_w_1983014102")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_Sw1NsgEcEeCQm6a_G2yO_w_1568063427")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Additional information associated with the sale transaction.
    /// </summary>
    [IsoId("_Sw1NswEcEeCQm6a_G2yO_w_842115279")]
    [DisplayName("Additional Sale Data")]
    [IsoXmlTag("AddtlSaleData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalSaleData { get; init; }
}
