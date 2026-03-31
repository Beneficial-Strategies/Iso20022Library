// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_kpi3wS_yEeO4w-IWHJMI9g")]
[DisplayName("Cardholder Authentication")]
public record CardholderAuthentication5
{
    /// <summary>
    /// Method used to authenticate a cardholder.
    /// </summary>
    [IsoId("_k_3GAS_yEeO4w-IWHJMI9g")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; }

    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_k_3GAy_yEeO4w-IWHJMI9g")]
    [DisplayName("Authentication Entity")]
    [IsoXmlTag("AuthntcnNtty")]
    public AuthenticationEntity1Code? AuthenticationEntity { get; init; }

    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_k_3GBS_yEeO4w-IWHJMI9g")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40, MinimumLength = 1)]
    public IsoMax40Text? AuthenticationValue { get; init; }

    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_k_3GBy_yEeO4w-IWHJMI9g")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN3? CardholderOnLinePIN { get; init; }

    /// <summary>
    /// Identifies in electronic commerce transactions whether customer authentication is supported and data is available.
    /// </summary>
    [IsoId("_k_3GCS_yEeO4w-IWHJMI9g")]
    [DisplayName("Authentication Collection Indicator")]
    [IsoXmlTag("AuthntcnColltnInd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AuthenticationCollectionIndicator { get; init; }
}
