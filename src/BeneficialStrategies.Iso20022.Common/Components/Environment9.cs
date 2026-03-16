// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_uiLcgWbaEeeNuKDeKoUMAA")]
[DisplayName("Environment")]
public record Environment9
{
    /// <summary>
    /// financial institution (or its agent) at which the accounts are held by the parties settling. This institution, acting on information provided by the parties, transfers the appropriate funds between the accounts.
    /// </summary>
    [IsoId("_uuMfQWbaEeeNuKDeKoUMAA")]
    [DisplayName("Settlement Institution")]
    [IsoXmlTag("SttlmInstn")]
    public PartyIdentification197? SettlementInstitution { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_GQcLsWp5EemXfKijhrqa-Q")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_uuMfRWbaEeeNuKDeKoUMAA")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Financial Institution to which the settlement totals apply.
    /// </summary>
    [IsoId("_uuMfQ2baEeeNuKDeKoUMAA")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution5? FinancialInstitution { get; init; }

    /// <summary>
    /// Additional institution involved in settlement. For example, the other party involved in bilateral settlement agreement.
    /// </summary>
    [IsoId("_uuMfR2baEeeNuKDeKoUMAA")]
    [DisplayName("Other Institution")]
    [IsoXmlTag("OthrInstn")]
    public PartyIdentification197? OtherInstitution { get; init; }
}
