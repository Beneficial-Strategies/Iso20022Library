// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_A1FWUW4-EeiU9cctagi5ow")]
[DisplayName("Limit Structure")]
public record LimitStructure3
{
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_A_hEs24-EeiU9cctagi5ow")]
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification2Choice_ LimitIdentification { get; init; }

    /// <summary>
    /// New limit values.
    /// </summary>
    [IsoId("_A_hEtW4-EeiU9cctagi5ow")]
    [DisplayName("New Limit Value Set")]
    [IsoXmlTag("NewLmtValSet")]
    public required Limit8 NewLimitValueSet { get; init; }
}
