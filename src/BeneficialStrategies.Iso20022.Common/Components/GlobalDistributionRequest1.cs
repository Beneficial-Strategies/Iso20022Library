// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the global distribution.
/// </summary>
[IsoId("_UKdzVdp-Ed-ak6NoX_4Aeg_-227934218")]
[DisplayName("Global Distribution Request")]
public record GlobalDistributionRequest1
{
    /// <summary>
    /// Indicates wether is message is an advice or pre-advice.
    /// </summary>
    [IsoId("_UKdzVtp-Ed-ak6NoX_4Aeg_-2123921749")]
    [DisplayName("Preadvice Indicator")]
    [IsoXmlTag("PradvcInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PreadviceIndicator { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UKdzV9p-Ed-ak6NoX_4Aeg_85141205")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UKdzWNp-Ed-ak6NoX_4Aeg_85141236")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; }

    /// <summary>
    /// Date on which the holders of securities are/will be recorded for the income being paid or for entitlement to the rights or offer/privilege.
    /// </summary>
    [IsoId("_UKdzWdp-Ed-ak6NoX_4Aeg_177913801")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public required DateFormat4Choice_ RecordDate { get; init; }

    /// <summary>
    /// Date on which securities/cash will be paid.
    /// </summary>
    [IsoId("_UKdzWtp-Ed-ak6NoX_4Aeg_221318375")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat4Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Provides information about the securities movement.
    /// </summary>
    [IsoId("_UKdzW9p-Ed-ak6NoX_4Aeg_1979460314")]
    [DisplayName("Securities Movement")]
    [IsoXmlTag("SctiesMvmnt")]
    public SecurityMovement1? SecuritiesMovement { get; init; }

    /// <summary>
    /// Provides information about the cash movement.
    /// </summary>
    [IsoId("_UKnkUNp-Ed-ak6NoX_4Aeg_1970224157")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public CashMovement1? CashMovement { get; init; }
}
