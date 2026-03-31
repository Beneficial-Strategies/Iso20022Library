// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant using the payment services of the card acceptor. The sponsored merchant is not acting as the card acceptor; the latter remaining the only party liable for the transaction vis-à-vis the acquirer.
/// </summary>
[IsoId("_r5V9EEXgEeegp_DADCe7HQ")]
[DisplayName("Sponsored Merchant")]
public record SponsoredMerchant1
{
    /// <summary>
    /// Identification of the sponsored merchant.
    /// </summary>
    [IsoId("_HH71UEXhEeegp_DADCe7HQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification197 Identification { get; init; }

    /// <summary>
    /// Additional identification information pertaining to the sponsored merchant.
    /// </summary>
    [IsoId("_kUYkkEXlEeegp_DADCe7HQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Contains the full name of the sponsored merchant.
    /// </summary>
    [IsoId("_u4cZMEXlEeegp_DADCe7HQ")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CommonName { get; init; }

    /// <summary>
    /// Address of the sponsored merchant.
    /// </summary>
    [IsoId("_2C_UUEXlEeegp_DADCe7HQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }
}
