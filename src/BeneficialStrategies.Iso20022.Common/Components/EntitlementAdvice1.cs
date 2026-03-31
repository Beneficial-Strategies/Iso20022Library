// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the CA entitlement.
/// </summary>
[IsoId("_UJIWmdp-Ed-ak6NoX_4Aeg_1024355345")]
[DisplayName("Entitlement Advice")]
public record EntitlementAdvice1
{
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJIWmtp-Ed-ak6NoX_4Aeg_1854599346")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UJIWm9p-Ed-ak6NoX_4Aeg_1854599377")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Date on which the holders of securities are/will be recorded for the income being paid or for entitlement to the rights or offer/privilege.
    /// </summary>
    [IsoId("_UJIWnNp-Ed-ak6NoX_4Aeg_235074739")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat4Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date on which securities/cash will be paid.
    /// </summary>
    [IsoId("_UJRggNp-Ed-ak6NoX_4Aeg_295101123")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat4Choice_? PaymentDate { get; init; }

    /// <summary>
    /// Provides information about the entitlement and the entitled account.
    /// </summary>
    [IsoId("_UJRggdp-Ed-ak6NoX_4Aeg_-1335835024")]
    [DisplayName("Account And Distribution Details")]
    [IsoXmlTag("AcctAndDstrbtnDtls")]
    public ValueList<Entitlement1> AccountAndDistributionDetails { get; init; } = [];
    // ID for the above is _UJRggdp-Ed-ak6NoX_4Aeg_-1335835024
}
