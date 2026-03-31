// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of format for the trading capacity.
/// </summary>
[IsoId("_YgDQfSs-EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
public record CollateralParties10
{
    /// <summary>
    /// Instructing party sending the collateral instruction.
    /// </summary>
    [IsoId("_Y4ovkSs-EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentificationAndAccount202 PartyA { get; init; }

    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_Y4ovkys-EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    [IsoXmlTag("ClntPtyA")]
    public PartyIdentificationAndAccount202? ClientPartyA { get; init; }

    /// <summary>
    /// Counterparty of party A.
    /// </summary>
    [IsoId("_Y4ovlSs-EeySlt9bF77XfA")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentificationAndAccount203 PartyB { get; init; }

    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_Y4ovlys-EeySlt9bF77XfA")]
    [DisplayName("Client Party B")]
    [IsoXmlTag("ClntPtyB")]
    public PartyIdentificationAndAccount203? ClientPartyB { get; init; }

    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_Y4ovmSs-EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification136? TripartyAgent { get; init; }

    /// <summary>
    /// Account where the collateral is held during the lifecycle  of the transaction.
    /// </summary>
    [IsoId("_Y4ovmys-EeySlt9bF77XfA")]
    [DisplayName("Collateral Account")]
    [IsoXmlTag("CollAcct")]
    public SecuritiesAccount19? CollateralAccount { get; init; }
}
