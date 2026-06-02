// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the cardholder.
/// </summary>
[IsoId("_9P-9MTTTEfCLfeKcVPKw8g")]
[DisplayName("Cardholder23")]
public record Cardholder23
{
    /// <summary>
    /// Name of the cardholder, which is usually the full name.
    /// </summary>
    [IsoId("_L64o5FN0EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_L64o5VN0EfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_L64o51N0EfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_L64o5lN0EfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Identifies the specific cardholder when multiple cardholders are associated with the same account.
    /// </summary>
    [IsoId("_dhuw2jTVEfCLfeKcVPKw8g")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax2NumericText? Designation { get; init; }

    /// <summary>
    /// Identification of the cardholder.
    /// </summary>
    [IsoId("_9SthEzTTEfCLfeKcVPKw8g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<Credentials3> Identification { get; init; } = [];

    /// <summary>
    /// Complete billing address of the cardholder.
    /// </summary>
    [IsoId("_9SthFTTTEfCLfeKcVPKw8g")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public Address4? BillingAddress { get; init; }

    /// <summary>
    /// Compressed billing address of the cardholder.
    /// </summary>
    [IsoId("_M6CB8DTZEfCLfeKcVPKw8g")]
    [DisplayName("Compressed Address")]
    [IsoXmlTag("CmprssdAdr")]
    public IsoMax35Text? CompressedAddress { get; init; }

    /// <summary>
    /// Complete shipping address of the cardholder.
    /// </summary>
    [IsoId("_wCen0TTYEfCLfeKcVPKw8g")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public ValueList<Address4> ShippingAddress { get; init; } = [];

    /// <summary>
    /// Contact information of the cardholder.
    /// </summary>
    [IsoId("_9SthFzTTEfCLfeKcVPKw8g")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactPersonal2? ContactInformation { get; init; }

    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_9SthGTTTEfCLfeKcVPKw8g")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Identifies a cardholder that is a highly valued individual.
    /// </summary>
    [IsoId("_9SthGzTTEfCLfeKcVPKw8g")]
    [DisplayName("High Value")]
    [IsoXmlTag("HghVal")]
    public IsoTrueFalseIndicator? HighValue { get; init; }

    /// <summary>
    /// Alias name of the payer.
    /// </summary>
    [IsoId("_JF-B0jTWEfCLfeKcVPKw8g")]
    [DisplayName("Alias Name")]
    [IsoXmlTag("AliasNm")]
    public IsoMax70Text? AliasName { get; init; }

    /// <summary>
    /// The occupation of the payer.
    /// </summary>
    [IsoId("_JF-B0zTWEfCLfeKcVPKw8g")]
    [DisplayName("Occupation")]
    [IsoXmlTag("Ocptn")]
    public IsoMax35Text? Occupation { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_X7dOokVZEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_X7dOo0VZEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_9SthHzTTEfCLfeKcVPKw8g")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData24? LocalData { get; init; }
}
