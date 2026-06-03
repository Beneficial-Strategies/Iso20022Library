// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and information about a securities account and balance.
/// </summary>
[IsoId("_f_MK0a5wEfCUHaCK5HWOhg")]
[DisplayName("Safekeeping Account20")]
public record SafekeepingAccount20
{
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_gFPIea5wEfCUHaCK5HWOhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained.
    /// </summary>
    [IsoId("_gFPIe65wEfCUHaCK5HWOhg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_gFPIfa5wEfCUHaCK5HWOhg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice? AccountOwner { get; init; }

    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_gFPIf65wEfCUHaCK5HWOhg")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_gFPIga5wEfCUHaCK5HWOhg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    [MinLength(1)]
    public ValueList<HoldingBalance15> InstructedBalance { get; init; } = [];

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_gFPIg65wEfCUHaCK5HWOhg")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public ValueList<PartyIdentification264Choice> RightsHolder { get; init; } = [];

    /// <summary>
    /// Detailed information about the pledge.
    /// </summary>
    [IsoId("_gFPIha5wEfCUHaCK5HWOhg")]
    [DisplayName("Pledge Details")]
    [IsoXmlTag("PldgDtls")]
    public PledgeInformation1? PledgeDetails { get; init; }
}
