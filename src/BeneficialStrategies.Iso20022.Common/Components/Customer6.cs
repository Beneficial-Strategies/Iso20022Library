// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer
/// </summary>
[IsoId("_vI2WVve_Eei89sMSHxl1ew")]
[DisplayName("Customer")]
public record Customer6
{
    /// <summary>
    /// Customer account number with the service provider.
    /// </summary>
    [IsoId("_vI2WWPe_Eei89sMSHxl1ew")]
    [DisplayName("Account Number")]
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountNumber { get; init; }

    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_vI2WWfe_Eei89sMSHxl1ew")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Customer&apos;s primary contact phone number.
    /// </summary>
    [IsoId("_72sh8fe_Eei89sMSHxl1ew")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }
}
