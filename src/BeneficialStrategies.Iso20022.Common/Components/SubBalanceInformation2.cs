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
[IsoId("_QY60U9p-Ed-ak6NoX_4Aeg_-1856391421")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation2
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QY60VNp-Ed-ak6NoX_4Aeg_-1856391403")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_QY60Vdp-Ed-ak6NoX_4Aeg_-1856391386")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SecuritiesBalanceType1Code SubBalanceType { get; init; }

    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QY60Vtp-Ed-ak6NoX_4Aeg_-1044552916")]
    [DisplayName("Extended Sub Balance Type")]
    [IsoXmlTag("XtndedSubBalTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedSubBalanceType { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_QY60V9p-Ed-ak6NoX_4Aeg_-1856391341")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; }
}
