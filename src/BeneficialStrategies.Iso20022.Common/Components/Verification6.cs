// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Verification6.
/// </summary>
[IsoId("_xdOlwXG3Ee60F8I8TAMKmg")]
[DisplayName("Verification6")]
public record Verification6
{
    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<VerificationValue1> Data { get; init; } = [];

    /// <summary>
    /// Entity.
    /// </summary>
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity2Code? Entity { get; init; }

    /// <summary>
    /// Other Entity.
    /// </summary>
    [DisplayName("Other Entity")]
    [IsoXmlTag("OthrNtty")]
    public IsoMax35Text? OtherEntity { get; init; }

    /// <summary>
    /// Other Result.
    /// </summary>
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    public IsoMax500Text? OtherResult { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// PIN Data.
    /// </summary>
    [DisplayName("PIN Data")]
    [IsoXmlTag("PINData")]
    public PINData1? PINData { get; init; }

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification3Code? Result { get; init; }

    /// <summary>
    /// Result Details.
    /// </summary>
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public ValueList<AdditionalData1> ResultDetails { get; init; } = [];

    /// <summary>
    /// Sub Type.
    /// </summary>
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; }
}
