// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Body of the Abort Request message.
/// </summary>
[IsoId("_cnvHcN6YEeiwsev40qZGEQ")]
[DisplayName("Abort Data")]
public record AbortData1
{
    /// <summary>
    /// Message identifier.
    /// </summary>
    [IsoId("_ldMFMN6YEeiwsev40qZGEQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Reason of aborting a transaction.
    /// </summary>
    [IsoId("_nyMNsN6YEeiwsev40qZGEQ")]
    [DisplayName("Abort Reason")]
    [IsoXmlTag("AbrtRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text AbortReason { get; init; }

    /// <summary>
    /// To display an abort message to the Customer.
    /// </summary>
    [IsoId("_qgSysN6YEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage6? DisplayOutput { get; init; }
}
