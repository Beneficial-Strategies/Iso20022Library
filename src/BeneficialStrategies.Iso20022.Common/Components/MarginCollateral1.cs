// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral held, in transit or that still needs to be agreed by both parties.
/// </summary>
[IsoId("_Uoa6pdp-Ed-ak6NoX_4Aeg_1642095269")]
[DisplayName("Margin Collateral")]
public record MarginCollateral1
{
    /// <summary>
    /// Post haircut market value of all margin collateral held by party A.
    /// </summary>
    [IsoId("_Uoa6ptp-Ed-ak6NoX_4Aeg_-733012556")]
    [DisplayName("Held By Party A")]
    [IsoXmlTag("HeldByPtyA")]
    public ActiveCurrencyAndAmount? HeldByPartyA { get; init; }

    /// <summary>
    /// Post haircut market value of all margin collateral held by party B.
    /// </summary>
    [IsoId("_Uoa6p9p-Ed-ak6NoX_4Aeg_-264212788")]
    [DisplayName("Held By Party B")]
    [IsoXmlTag("HeldByPtyB")]
    public ActiveCurrencyAndAmount? HeldByPartyB { get; init; }

    /// <summary>
    /// Sum of all margin agreed amounts due to party A from prior days’ collateral calls where collateral movements have not yet been agreed.
    /// </summary>
    [IsoId("_Uoa6qNp-Ed-ak6NoX_4Aeg_609978302")]
    [DisplayName("Prior Agreed To Party A")]
    [IsoXmlTag("PrrAgrdToPtyA")]
    public ActiveCurrencyAndAmount? PriorAgreedToPartyA { get; init; }

    /// <summary>
    /// Sum of all margin agreed amounts due to party B from prior days’ collateral calls where collateral movements have not yet been agreed.
    /// </summary>
    [IsoId("_Uoa6qdp-Ed-ak6NoX_4Aeg_316227488")]
    [DisplayName("Prior Agreed To Party B")]
    [IsoXmlTag("PrrAgrdToPtyB")]
    public ActiveCurrencyAndAmount? PriorAgreedToPartyB { get; init; }

    /// <summary>
    /// Sum of all margin collateral movements due to party A in progress but not yet settled.
    /// </summary>
    [IsoId("_Uoa6qtp-Ed-ak6NoX_4Aeg_-11345204")]
    [DisplayName("In Transit To Party A")]
    [IsoXmlTag("InTrnstToPtyA")]
    public ActiveCurrencyAndAmount? InTransitToPartyA { get; init; }

    /// <summary>
    /// Sum of all margin collateral movements due to party B in progress but not yet settled.
    /// </summary>
    [IsoId("_Uoa6q9p-Ed-ak6NoX_4Aeg_1038693613")]
    [DisplayName("In Transit To Party B")]
    [IsoXmlTag("InTrnstToPtyB")]
    public ActiveCurrencyAndAmount? InTransitToPartyB { get; init; }
}
