// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted Data2.
/// </summary>
[IsoId("_cTpNkXdBEe6YlIMyoxWMJA")]
[DisplayName("Encrypted Data2")]
public record EncryptedData2
{
    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public IsoMax2NumericText? Algorithm { get; init; }

    /// <summary>
    /// Control.
    /// </summary>
    [DisplayName("Control")]
    [IsoXmlTag("Ctrl")]
    public IsoExact1HexBinaryText? Control { get; init; }

    /// <summary>
    /// Derived Information.
    /// </summary>
    [DisplayName("Derived Information")]
    [IsoXmlTag("DrvdInf")]
    public IsoMax32HexBinaryText? DerivedInformation { get; init; }

    /// <summary>
    /// Encrypted Element.
    /// </summary>
    [DisplayName("Encrypted Element")]
    [IsoXmlTag("NcrptdElmt")]
    public ValueList<EncryptedDataElement2> EncryptedElement { get; init; } = [];

    /// <summary>
    /// Encrypted Format.
    /// </summary>
    [DisplayName("Encrypted Format")]
    [IsoXmlTag("NcrptdFrmt")]
    public IsoMax2NumericText? EncryptedFormat { get; init; }

    /// <summary>
    /// Key Index.
    /// </summary>
    [DisplayName("Key Index")]
    [IsoXmlTag("KeyIndx")]
    public IsoMax5NumericText? KeyIndex { get; init; }

    /// <summary>
    /// Key Length.
    /// </summary>
    [DisplayName("Key Length")]
    [IsoXmlTag("KeyLngth")]
    public IsoMax4NumericText? KeyLength { get; init; }

    /// <summary>
    /// Key Protection.
    /// </summary>
    [DisplayName("Key Protection")]
    [IsoXmlTag("KeyPrtcn")]
    public IsoMax2NumericText? KeyProtection { get; init; }

    /// <summary>
    /// Key Set Identifier.
    /// </summary>
    [DisplayName("Key Set Identifier")]
    [IsoXmlTag("KeySetIdr")]
    public IsoMax8NumericText? KeySetIdentifier { get; init; }

    /// <summary>
    /// Padding Method.
    /// </summary>
    [DisplayName("Padding Method")]
    [IsoXmlTag("PddgMtd")]
    public IsoMax2NumericText? PaddingMethod { get; init; }
}
