// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_VaVfxtp-Ed-ak6NoX_4Aeg_-1947453063")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_VaVfx9p-Ed-ak6NoX_4Aeg_591039961")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationFormatChoice_ Identification { get; init; }

    /// <summary>
    /// Indicates whether the securities in the account are fungible, ie, interchangeable.
    /// </summary>
    [IsoId("_VaVfyNp-Ed-ak6NoX_4Aeg_591040831")]
    [DisplayName("Fungible Indicator")]
    [IsoXmlTag("FngbInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FungibleIndicator { get; init; }

    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_VaVfydp-Ed-ak6NoX_4Aeg_591041666")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_VaVfytp-Ed-ak6NoX_4Aeg_-1504202025")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation2> BalanceForSubAccount { get; init; } = [];
}
