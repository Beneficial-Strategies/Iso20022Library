// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to the beneficiary.
/// </summary>
[IsoId("_-EXduHltEeG7BsjMvd1mEw_-57311934")]
[DisplayName("Beneficiary")]
public record Beneficiary1
{
    /// <summary>
    /// New beneficiary address, or new beneficiary name and address.
    /// </summary>
    [IsoId("_-EXduXltEeG7BsjMvd1mEw_-1298911644")]
    [DisplayName("New Address Or New Beneficiary")]
    [IsoXmlTag("NewAdrOrNewBnfcry")]
    public required AddressOrParty1Choice_ NewAddressOrNewBeneficiary { get; init; }

    /// <summary>
    /// Additional information concerning the amended beneficiary details.
    /// </summary>
    [IsoId("_-EhOsHltEeG7BsjMvd1mEw_1955117019")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
