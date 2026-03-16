// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Filter to compute the totals.
/// </summary>
[IsoId("_Qu5qgN6TEeiwsev40qZGEQ")]
[DisplayName("Total Filter")]
public record TotalFilter1
{
    /// <summary>
    /// Identifier of the POI system performing a reconciliation.
    /// </summary>
    [IsoId("_Y6snQN6TEeiwsev40qZGEQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_b2wIsN6TEeiwsev40qZGEQ")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_fp-isN6TEeiwsev40qZGEQ")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_idX3YN6TEeiwsev40qZGEQ")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShiftNumber { get; init; }

    /// <summary>
    /// Identification of a group of transaction on a POI Terminal, having the same Sale features.
    /// </summary>
    [IsoId("_l1j7MN6TEeiwsev40qZGEQ")]
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TotalsGroupIdentification { get; init; }
}
