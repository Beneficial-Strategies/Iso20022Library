// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the margin report per clearing member, and optionally either per financial instrument or per non-clearing member.
/// </summary>
[IsoId("_UksRONp-Ed-ak6NoX_4Aeg_-985439899")]
[DisplayName("Margin Report1")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public record MarginReport1
{
    /// <summary>
    /// Identifies the clearing member's account.
    /// </summary>
    [IsoId("_Uk2CMNp-Ed-ak6NoX_4Aeg_543914632")]
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public required SecuritiesAccount18 MarginAccount { get; init; }

    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_Uk2CMdp-Ed-ak6NoX_4Aeg_-1346583456")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public ValueList<PartyIdentificationAndAccount31> NonClearingMember { get; init; } = [];

    /// <summary>
    /// Specifies if the margin is related to equities or fixed income.
    /// </summary>
    [IsoId("_Uk2CMtp-Ed-ak6NoX_4Aeg_394991412")]
    [DisplayName("Margin Product")]
    [IsoXmlTag("MrgnPdct")]
    [MinLength(1)]
    public ValueList<MarginProductType1Choice_> MarginProduct { get; init; } = [];

    /// <summary>
    /// Provides the margin details such as the exposure amount and the initial margin.
    /// </summary>
    [IsoId("_Uk2CM9p-Ed-ak6NoX_4Aeg_-1376804738")]
    [DisplayName("Margin Details")]
    [IsoXmlTag("MrgnDtls")]
    [MinLength(1)]
    public ValueList<Margin2> MarginDetails { get; init; } = [];
}
