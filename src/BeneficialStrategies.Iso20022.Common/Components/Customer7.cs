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
[IsoId("_M8YtEKd1EeuEcqP2FGAFaA")]
[DisplayName("Customer")]
public record Customer7
{
    /// <summary>
    /// Identification of the customer assigned by a party.
    /// </summary>
    [IsoId("_NCiYYad1EeuEcqP2FGAFaA")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; }

    /// <summary>
    /// Identifies the specific customer when multiple customers are associated with the same account.
    /// </summary>
    [IsoId("_wUjUgKd1EeuEcqP2FGAFaA")]
    [DisplayName("Customer Designation")]
    [IsoXmlTag("CstmrDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? CustomerDesignation { get; init; }

    /// <summary>
    /// Name of the financial customer.
    /// </summary>
    [IsoId("_NCiYY6d1EeuEcqP2FGAFaA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName3? Name { get; init; }

    /// <summary>
    /// Address of the financial customer.
    /// </summary>
    [IsoId("_NCiYZad1EeuEcqP2FGAFaA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Detail contact information of the customer.
    /// </summary>
    [IsoId("_IOj7UCbSEeyhZIgCcGlTyA")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public Contact6? ContactInformation { get; init; }

    /// <summary>
    /// Credentials of the financial customer.
    /// </summary>
    [IsoId("_NCiYZ6d1EeuEcqP2FGAFaA")]
    [DisplayName("Credentials")]
    [IsoXmlTag("Crdntls")]
    public ValueList<Credentials2> Credentials { get; init; } = [];

    /// <summary>
    /// Nationality information (ISO 3166-1 alpha-2 or alpha-3)
    /// </summary>
    [IsoId("_QmcMQCbSEeyhZIgCcGlTyA")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public ISOMax3ACountryCode? Nationality { get; init; }

    /// <summary>
    /// Country of Birth information (ISO 3166-1 alpha-2 or alpha-3)
    /// </summary>
    [IsoId("_XdeVgCbSEeyhZIgCcGlTyA")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public ISOMax3ACountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_NCiYa6d1EeuEcqP2FGAFaA")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_F3oz4MWxEeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData3? LocalData { get; init; }

    /// <summary>
    /// Additional information related to the customer.
    /// </summary>
    [IsoId("_NCiYaad1EeuEcqP2FGAFaA")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
