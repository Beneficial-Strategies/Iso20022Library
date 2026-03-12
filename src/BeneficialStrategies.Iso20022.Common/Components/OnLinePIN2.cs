// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
[IsoId("_P7g84QvTEeKzJ69IWwzB9Q")]
[DisplayName("On Line PIN")]
public partial record OnLinePIN2
{
    #nullable enable
    
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    [IsoId("_QG01AQvTEeKzJ69IWwzB9Q")]
    [DisplayName("Encrypted PIN Block")]
    [IsoXmlTag("NcrptdPINBlck")]
    public required ContentInformationType5 EncryptedPINBlock { get; init; } 
    
    /// <summary>
    /// PIN format before encryption.
    /// </summary>
    [IsoId("_QG01BQvTEeKzJ69IWwzB9Q")]
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public required PINFormat2Code PINFormat { get; init; } 
    
    /// <summary>
    /// Additional information required to verify the PIN.
    /// </summary>
    [IsoId("_QG01CQvTEeKzJ69IWwzB9Q")]
    [DisplayName("Additional Input")]
    [IsoXmlTag("AddtlInpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalInput { get; init; } 
    
    
    #nullable disable
    
}
