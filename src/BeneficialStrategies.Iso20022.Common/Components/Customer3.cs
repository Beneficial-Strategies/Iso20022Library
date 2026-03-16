// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the customer in a transfer of money.
/// </summary>
[IsoId("_q6pIUEB-EeeXpbqDpLawug")]
[DisplayName("Customer")]
public record Customer3
{
    /// <summary>
    /// Identification of the customer assigned by a party.
    /// </summary>
    [IsoId("_oI6qUBVjEei_7rtBiunN6A")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; }

    /// <summary>
    /// Name of the financial customer.
    /// </summary>
    [IsoId("_Cza7UEB_EeeXpbqDpLawug")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Address of the financial customer.
    /// </summary>
    [IsoId("_HBTRAEB_EeeXpbqDpLawug")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Credentials of the financial customer.
    /// </summary>
    [IsoId("_DEsCwECFEeeXpbqDpLawug")]
    [DisplayName("Credentials")]
    [IsoXmlTag("Crdntls")]
    public Credentials1? Credentials { get; init; }

    /// <summary>
    /// Additional information related to the customer.
    /// </summary>
    [IsoId("_Dc28oBVkEei_7rtBiunN6A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_K3F7MBqYEeqH1IQNpbVpEw")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }
}
