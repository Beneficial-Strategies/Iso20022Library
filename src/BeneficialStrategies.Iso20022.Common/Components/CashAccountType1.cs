// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the cash account.
/// </summary>
[IsoId("_VJzJZdp-Ed-ak6NoX_4Aeg_-1239141267")]
[DisplayName("Cash Account Type")]
public record CashAccountType1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VJzJZtp-Ed-ak6NoX_4Aeg_-1158797592")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required FundCashAccount1Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VJzJZ9p-Ed-ak6NoX_4Aeg_-1141250703")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
