// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// On Line PIN11.
/// </summary>
[IsoId("_ICLSwY-bEe6oobnCtR50kw")]
[DisplayName("On Line PIN11")]
public partial record OnLinePIN11
{
    #nullable enable

    /// <summary>
    /// Additional Input.
    /// </summary>
    [DisplayName("Additional Input")]
    [IsoXmlTag("AddtlInpt")]
    public IsoMax35Text? AdditionalInput { get; init; } 

    /// <summary>
    /// Encrypted PIN Block.
    /// </summary>
    [DisplayName("Encrypted PIN Block")]
    [IsoXmlTag("NcrptdPINBlck")]
    public required ContentInformationType40 EncryptedPINBlock { get; init; } 

    /// <summary>
    /// PIN Format.
    /// </summary>
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public required PINFormat3Code PINFormat { get; init; } 

    
    #nullable disable
    
}
