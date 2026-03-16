// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the terminal performing the transaction.
/// </summary>
[IsoId("_dbsMF-wOEeiMkKo2clXHdQ")]
[DisplayName("Terminal Identification")]
public record TerminalIdentification2
{
    /// <summary>
    /// Identification of the terminal.
    /// ISO 8583 bit 41
    /// </summary>
    [IsoId("_dbszIuwOEeiMkKo2clXHdQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Identification { get; init; }

    /// <summary>
    /// Type of terminal.
    /// </summary>
    [IsoId("_dbszI-wOEeiMkKo2clXHdQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType1Code? Type { get; init; }

    /// <summary>
    /// Other type of terminal.
    /// </summary>
    [IsoId("_dbszJOwOEeiMkKo2clXHdQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Assignor of the terminal identification.
    /// </summary>
    [IsoId("_dbszIOwOEeiMkKo2clXHdQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country of the terminal.
    /// </summary>
    [IsoId("_dbszIewOEeiMkKo2clXHdQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }

    /// <summary>
    /// Short name of the terminal.
    /// </summary>
    [IsoId("_dbszJewOEeiMkKo2clXHdQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
