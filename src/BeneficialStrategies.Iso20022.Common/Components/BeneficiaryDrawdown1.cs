// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the beneficiary of a drawdown.
/// </summary>
[IsoId("_l8_kcFNgEeijdq8ilaxyOA")]
[DisplayName("Beneficiary Drawdown")]
public record BeneficiaryDrawdown1
{
    /// <summary>
    /// Type of beneficiary.
    /// </summary>
    [IsoId("_q0YKIFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Type")]
    [IsoXmlTag("BnfcryTp")]
    public BeneficiaryType1Choice_? BeneficiaryType { get; init; }

    /// <summary>
    /// Indicates whether the original pension holder was under the age limit when deceased. Typically, in the UK this limit is seventy-five.
    /// </summary>
    [IsoId("_salS8FNgEeijdq8ilaxyOA")]
    [DisplayName("Death Under Limit")]
    [IsoXmlTag("DthUdrLmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DeathUnderLimit { get; init; }

    /// <summary>
    /// Additional information about the recipient of the drawdown.
    /// </summary>
    [IsoId("_7qdhYZC0EeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
