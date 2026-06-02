// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Application specific information defined by the service provider.
/// </summary>
[IsoId("_7G4bURUZEfCfALVKQ4rOew")]
[DisplayName("Application Specifics2")]
public record ApplicationSpecifics2
{
    /// <summary>
    /// Account of a user of the receiving business application and defined in the static data of the receiving business application.
    /// </summary>
    [IsoId("_7Hs6sRUZEfCfALVKQ4rOew")]
    [DisplayName("System User Account")]
    [IsoXmlTag("SysUsrAcct")]
    public IsoMax140Text? SystemUserAccount { get; init; }

    /// <summary>
    /// Digital signature(s) of the Business Entity authorised to sign this Business File.
    /// </summary>
    [IsoId("_7Hs6sxUZEfCfALVKQ4rOew")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SimpleValueList<IsoSignatureEnvelope> Signature { get; init; } = [];

    /// <summary>
    /// Total number of instances (messages) within the file.
    /// </summary>
    [IsoId("_7Hs6tRUZEfCfALVKQ4rOew")]
    [DisplayName("Total Number Of Business Messages")]
    [IsoXmlTag("TtlNbOfBizMsgs")]
    public IsoNumber? TotalNumberOfBusinessMessages { get; init; }
}
