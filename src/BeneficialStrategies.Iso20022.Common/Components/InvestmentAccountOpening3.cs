// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of opening instruction and identification of the application request.
/// </summary>
[IsoId("_J-CIcUzKEeafiMTDrtSnyw")]
[DisplayName("Investment Account Opening")]
public record InvestmentAccountOpening3
{
    /// <summary>
    /// Specifies if the account opening instruction is about a newly created account or a supplementary account.
    /// </summary>
    [IsoId("_KYDyAUzKEeafiMTDrtSnyw")]
    [DisplayName("Opening Type")]
    [IsoXmlTag("OpngTp")]
    public required AccountOpeningType1Choice_ OpeningType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening request at application level.
    /// </summary>
    [IsoId("_KYDyA0zKEeafiMTDrtSnyw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [IsoId("_KYDyBUzKEeafiMTDrtSnyw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_KYDyB0zKEeafiMTDrtSnyw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference6? CounterpartyReference { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_KYDyCUzKEeafiMTDrtSnyw")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public ValueList<Account23> ExistingAccountIdentification { get; init; } = [];
}
