// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_VDPOYNp-Ed-ak6NoX_4Aeg_-1623978641")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation1
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_VDPOYdp-Ed-ak6NoX_4Aeg_-1293358634")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_VDPOYtp-Ed-ak6NoX_4Aeg_-1293357608")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SecuritiesBalanceType1Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VDPOY9p-Ed-ak6NoX_4Aeg_534538364")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
