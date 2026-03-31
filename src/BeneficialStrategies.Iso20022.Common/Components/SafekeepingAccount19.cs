// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Safekeeping Account19.
/// </summary>
[IsoId("_6iIdw4-9Ee-COKgew96POA")]
[DisplayName("Safekeeping Account19")]
public record SafekeepingAccount19
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Instructed Balance.
    /// </summary>
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required HoldingBalance15 InstructedBalance { get; init; }

    /// <summary>
    /// Pledge Details.
    /// </summary>
    [DisplayName("Pledge Details")]
    [IsoXmlTag("PldgDtls")]
    public PledgeInformation1? PledgeDetails { get; init; }

    /// <summary>
    /// Rights Holder.
    /// </summary>
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public PartyIdentification246Choice_? RightsHolder { get; init; }

    /// <summary>
    /// Sub Account Identification.
    /// </summary>
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }
}
