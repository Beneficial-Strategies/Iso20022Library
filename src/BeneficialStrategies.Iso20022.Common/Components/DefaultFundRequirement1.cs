// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.
/// </summary>
[IsoId("_UvqKAKp3EeamNLogr5TkIQ")]
[DisplayName("Default Fund Requirement")]
public record DefaultFundRequirement1
{
    /// <summary>
    /// Identification of the clearing member.
    /// </summary>
    [IsoId("_KvDyUKp4EeamNLogr5TkIQ")]
    [DisplayName("Clearing Member Identification")]
    [IsoXmlTag("ClrMmbId")]
    public required GenericIdentification165 ClearingMemberIdentification { get; init; }

    /// <summary>
    /// Central counterparty&apos;s identification of the service where default fund contributions are made at the service level.
    /// </summary>
    [IsoId("_T0Xt0cBtEeak3I7j2hsibw")]
    [DisplayName("Service Identification")]
    [IsoXmlTag("SvcId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceIdentification { get; init; }

    /// <summary>
    /// Clearing member&apos;s pre-funded default fund requirement for the default fund at the central counterparty.
    /// </summary>
    [IsoId("_T0Xt0sBtEeak3I7j2hsibw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
