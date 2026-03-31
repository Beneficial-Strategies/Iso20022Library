// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about a member of a loyalty programme.
/// </summary>
[IsoId("_P8wQccW2EeuhguwJmlgagQ")]
[DisplayName("Loyalty Member")]
public record LoyaltyMember2
{
    /// <summary>
    /// Name of the member of the loyalty programme.
    /// </summary>
    [IsoId("_QBaG8cW2EeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName3? Name { get; init; }

    /// <summary>
    /// Address of the loyalty member.
    /// </summary>
    [IsoId("_QBaG88W2EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Identification of the member of the loyalty programme.
    /// </summary>
    [IsoId("_QBaG9cW2EeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Status of the loyalty programme member for the programme.
    /// </summary>
    [IsoId("_QBaG98W2EeuhguwJmlgagQ")]
    [DisplayName("Member Status")]
    [IsoXmlTag("MmbSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MemberStatus { get; init; }

    /// <summary>
    /// Expiration date of the loyalty programme.
    /// </summary>
    [IsoId("_QBaG-cW2EeuhguwJmlgagQ")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Value expressed in type of value for the loyalty programme.
    /// </summary>
    [IsoId("_QBaG-8W2EeuhguwJmlgagQ")]
    [DisplayName("Loyalty Value")]
    [IsoXmlTag("LltyVal")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? LoyaltyValue { get; init; }

    /// <summary>
    /// Type of value used for the loyalty programme.
    /// </summary>
    [IsoId("_QBaG_cW2EeuhguwJmlgagQ")]
    [DisplayName("Loyalty Value Type")]
    [IsoXmlTag("LltyValTp")]
    public LoyaltyValueType1Code? LoyaltyValueType { get; init; }

    /// <summary>
    /// Other type of loyalty value used for the programme.
    /// </summary>
    [IsoId("_QBaG_8W2EeuhguwJmlgagQ")]
    [DisplayName("Other Loyalty Value Type")]
    [IsoXmlTag("OthrLltyValTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherLoyaltyValueType { get; init; }

    /// <summary>
    /// Value to be credited on the account of the loyalty programme member. Computed on the monetary part actually paid by the customer for the service.
    /// </summary>
    [IsoId("_QBaHAcW2EeuhguwJmlgagQ")]
    [DisplayName("Value To Credit")]
    [IsoXmlTag("ValToCdt")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? ValueToCredit { get; init; }

    /// <summary>
    /// Value to be debited from the account of the loyalty programme member. Computed on the monetary part actually redeemed by the customer for the service.
    /// </summary>
    [IsoId("_QBaHA8W2EeuhguwJmlgagQ")]
    [DisplayName("Value To Debit")]
    [IsoXmlTag("ValToDbt")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? ValueToDebit { get; init; }

    /// <summary>
    /// Value on the account of the loyalty programme member after credit (computation on actual payment in monetary value) and debit (redemption in loyalty value).
    /// </summary>
    [IsoId("_QBaHBcW2EeuhguwJmlgagQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? Balance { get; init; }
}
