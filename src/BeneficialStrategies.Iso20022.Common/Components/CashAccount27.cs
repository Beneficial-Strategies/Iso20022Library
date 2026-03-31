// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify an account.
/// </summary>
[IsoId("_z0X-UohEEeG5nNTyZYbxsA")]
[DisplayName("Cash Account")]
public record CashAccount27
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_z0X-VYhEEeG5nNTyZYbxsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    [IsoId("_z0X-W4hEEeG5nNTyZYbxsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2? Type { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_z0X-XohEEeG5nNTyZYbxsA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_z0X-Z4hEEeG5nNTyZYbxsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_z0X-ZIhEEeG5nNTyZYbxsA")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification41? Owner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_z0X-YYhEEeG5nNTyZYbxsA")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification5? Servicer { get; init; }
}
