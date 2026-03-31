// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Way to identify a customer account or a relationship to its account affected for the transaction.
/// </summary>
[IsoId("_2YV4AHs6EeSTS7uHCe8FPQ")]
[DisplayName("Card Account")]
public record CardAccount1
{
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_nfsMQHs7EeSTS7uHCe8FPQ")]
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_xyQoQHs7EeSTS7uHCe8FPQ")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType2Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_59ouQHs7EeSTS7uHCe8FPQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_BhfhQHs8EeSTS7uHCe8FPQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_wxLwUHs8EeSTS7uHCe8FPQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification30Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_j-E0wHs9EeSTS7uHCe8FPQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }
}
