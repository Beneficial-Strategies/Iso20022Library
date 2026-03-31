// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_E3Yeqx5gEeWE3PufGMdJ3w")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount112
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_FWeOMx5gEeWE3PufGMdJ3w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification94Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_sjIl4GzLEeWAUO-90GtZEg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_FWeOOx5gEeWE3PufGMdJ3w")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_FWeOQx5gEeWE3PufGMdJ3w")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_FWeOSx5gEeWE3PufGMdJ3w")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; }

    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_FWeOUx5gEeWE3PufGMdJ3w")]
    [DisplayName("Commission Account")]
    [IsoXmlTag("ComssnAcct")]
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; }

    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_FWeOWx5gEeWE3PufGMdJ3w")]
    [DisplayName("Tax Account")]
    [IsoXmlTag("TaxAcct")]
    public CashAccountIdentification5Choice_? TaxAccount { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_FWeOYx5gEeWE3PufGMdJ3w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation2? AdditionalInformation { get; init; }
}
