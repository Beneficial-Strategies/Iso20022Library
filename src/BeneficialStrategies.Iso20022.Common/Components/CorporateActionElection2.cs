// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a corporate action election amendment request.
/// </summary>
[IsoId("_UJ39ctp-Ed-ak6NoX_4Aeg_-1290336513")]
[DisplayName("Corporate Action Election")]
public record CorporateActionElection2
{
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJ39c9p-Ed-ak6NoX_4Aeg_-1233077575")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UJ39dNp-Ed-ak6NoX_4Aeg_-1233077544")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// New instructed securities quantity after the amendment.
    /// </summary>
    [IsoId("_UJ39ddp-Ed-ak6NoX_4Aeg_-1233077543")]
    [DisplayName("New Instructed Quantity")]
    [IsoXmlTag("NewInstdQty")]
    public required UnitOrFaceAmount1Choice_ NewInstructedQuantity { get; init; }

    /// <summary>
    /// The reason for the amendment request.
    /// </summary>
    [IsoId("_UJ39dtp-Ed-ak6NoX_4Aeg_-1222919883")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; }
}
