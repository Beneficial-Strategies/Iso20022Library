// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Structure5.
/// </summary>
[IsoId("_0RkN8TEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Structure5")]
public record LimitStructure5
{
    /// <summary>
    /// Limit Identification.
    /// </summary>
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification3Choice_ LimitIdentification { get; init; }

    /// <summary>
    /// Limit Value Amendment.
    /// </summary>
    [DisplayName("Limit Value Amendment")]
    [IsoXmlTag("LmtValAmdmnt")]
    public Amount4Choice_? LimitValueAmendment { get; init; }

    /// <summary>
    /// New Limit Value Set.
    /// </summary>
    [DisplayName("New Limit Value Set")]
    [IsoXmlTag("NewLmtValSet")]
    public required Limit8 NewLimitValueSet { get; init; }

    /// <summary>
    /// Old Limit Value Set.
    /// </summary>
    [DisplayName("Old Limit Value Set")]
    [IsoXmlTag("OdLmtValSet")]
    public Limit10? OldLimitValueSet { get; init; }
}
