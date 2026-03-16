// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card security code (CSC) associated with the card performing the transaction.
/// </summary>
[IsoId("_SqR5xAEcEeCQm6a_G2yO_w_383431093")]
[DisplayName("Card Security Information")]
public record CardSecurityInformation1
{
    /// <summary>
    /// Card security code (CSC) management associated with the transaction.
    /// </summary>
    [IsoId("_SqR5xQEcEeCQm6a_G2yO_w_-2115154942")]
    [DisplayName("CSC Management")]
    [IsoXmlTag("CSCMgmt")]
    public required CSCManagement1Code CSCManagement { get; init; }

    /// <summary>
    /// Card security code (CSC).
    /// </summary>
    [IsoId("_SqR5xgEcEeCQm6a_G2yO_w_494973003")]
    [DisplayName("CSC Value")]
    [IsoXmlTag("CSCVal")]
    [IsoSimpleType(IsoSimpleType.Min3Max4NumericText)]
    public IsoMin3Max4NumericText? CSCValue { get; init; }
}
