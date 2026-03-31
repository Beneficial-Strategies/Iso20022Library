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
[IsoId("_Fw2qQQvUEeKzJ69IWwzB9Q")]
[DisplayName("Cardholder Authentication")]
public record CardholderAuthentication3
{
    /// <summary>
    /// Method used to authenticate a cardholder.
    /// </summary>
    [IsoId("_F8AxYQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Method")]
    [IsoXmlTag("AuthntcnMtd")]
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; }

    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_F8AxZQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Entity")]
    [IsoXmlTag("AuthntcnNtty")]
    public AuthenticationEntity1Code? AuthenticationEntity { get; init; }

    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_F8AxaQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Value")]
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40, MinimumLength = 1)]
    public IsoMax40Text? AuthenticationValue { get; init; }

    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_F8AxbQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Cardholder On Line PIN")]
    [IsoXmlTag("CrdhldrOnLinePIN")]
    public OnLinePIN2? CardholderOnLinePIN { get; init; }

    /// <summary>
    /// Identifies in electronic commerce transactions whether customer authentication is supported and data is available.
    /// </summary>
    [IsoId("_F8AxcQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Collection Indicator")]
    [IsoXmlTag("AuthntcnColltnInd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AuthenticationCollectionIndicator { get; init; }
}
