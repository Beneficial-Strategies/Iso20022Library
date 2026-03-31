// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Input Result Data6.
/// </summary>
[IsoId("_3JdwsZCAEe6FLLjWp95ntQ")]
[DisplayName("Input Result Data6")]
public record InputResultData6
{
    /// <summary>
    /// Confirmed Flag.
    /// </summary>
    [DisplayName("Confirmed Flag")]
    [IsoXmlTag("ConfdFlg")]
    public IsoTrueFalseIndicator? ConfirmedFlag { get; init; }

    /// <summary>
    /// Function Key.
    /// </summary>
    [DisplayName("Function Key")]
    [IsoXmlTag("FctnKey")]
    public IsoNumber? FunctionKey { get; init; }

    /// <summary>
    /// Image Captured Signature.
    /// </summary>
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; }

    /// <summary>
    /// Input Command.
    /// </summary>
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; }

    /// <summary>
    /// Input Message.
    /// </summary>
    [DisplayName("Input Message")]
    [IsoXmlTag("InptMsg")]
    public IsoMax20000Text? InputMessage { get; init; }

    /// <summary>
    /// Password.
    /// </summary>
    [DisplayName("Password")]
    [IsoXmlTag("Pwd")]
    public ContentInformationType39? Password { get; init; }
}
