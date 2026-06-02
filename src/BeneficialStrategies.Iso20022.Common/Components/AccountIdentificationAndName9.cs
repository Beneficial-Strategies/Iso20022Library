// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a name and an account number.
/// </summary>
[IsoId("f82cd3a1-ac19-41c7-8cd3-2e27153354cc")]
[DisplayName("Account Identification And Name9")]
public record AccountIdentificationAndName9
{
    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("d4d4425a-ba60-431e-841e-607546bc6e34")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN).
    /// </summary>
    [IsoId("4043bfca-4b91-4a31-8759-d8fec6a865ef")]
    [DisplayName("IBAN")]
    [IsoXmlTag("IBAN")]
    public IsoIBAN2007Identifier? IBAN { get; init; }

    /// <summary>
    /// Block Chain Wallet where digital currencies are maintained.
    /// </summary>
    [IsoId("d13e1626-6648-4e60-92b9-a9579180c07b")]
    [DisplayName("Block Chain Cash Wallet")]
    [IsoXmlTag("BlckChainCshWllt")]
    public BlockChainAddressWallet3? BlockChainCashWallet { get; init; }

    /// <summary>
    /// Unique identification of the account, as assigned by the account servicer, using an identification scheme.
    /// </summary>
    [IsoId("d0ecda77-0550-4d62-863e-488c0dfdbe78")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericAccountIdentification1? Other { get; init; }
}
