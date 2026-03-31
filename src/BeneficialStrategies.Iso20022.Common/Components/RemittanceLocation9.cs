// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Location9.
/// </summary>
[IsoId("_060mUTEyEe6g-ffJsqGiSA")]
[DisplayName("Remittance Location9")]
public record RemittanceLocation9
{
    /// <summary>
    /// Remittance Identification.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Remittance Location Electronic Address.
    /// </summary>
    [DisplayName("Remittance Location Electronic Address")]
    [IsoXmlTag("RmtLctnElctrncAdr")]
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; }

    /// <summary>
    /// Remittance Location Method.
    /// </summary>
    [DisplayName("Remittance Location Method")]
    [IsoXmlTag("RmtLctnMtd")]
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; }

    /// <summary>
    /// Remittance Location Postal Address.
    /// </summary>
    [DisplayName("Remittance Location Postal Address")]
    [IsoXmlTag("RmtLctnPstlAdr")]
    public NameAndAddress18? RemittanceLocationPostalAddress { get; init; }
}
