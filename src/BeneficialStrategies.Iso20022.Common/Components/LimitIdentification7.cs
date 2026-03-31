// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Identification7.
/// </summary>
[IsoId("_DuabcWdmEemMLeaDfmIfIA")]
[DisplayName("Limit Identification7")]
public record LimitIdentification7
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification4Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification136 AccountOwner { get; init; }

    /// <summary>
    /// Bilateral Limit Counterparty Identification.
    /// </summary>
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public SystemPartyIdentification8? BilateralLimitCounterpartyIdentification { get; init; }

    /// <summary>
    /// Limit Currency.
    /// </summary>
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LimitType4Code Type { get; init; }
}
