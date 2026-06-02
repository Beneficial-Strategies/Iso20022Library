// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related the acceptor.
/// </summary>
[IsoId("_8SvWgbAREfCwE42C7pOZ8A")]
[DisplayName("Acceptor Data4")]
public record AcceptorData4
{
    /// <summary>
    /// Identification of the acceptor.
    /// </summary>
    [IsoId("_8V_e0bAREfCwE42C7pOZ8A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification to the acceptor assigned by the scheme.
    /// </summary>
    [IsoId("_8V_e2bAREfCwE42C7pOZ8A")]
    [DisplayName("Scheme Assigned Identification")]
    [IsoXmlTag("SchmeAssgndId")]
    public IsoMax15AlphaNumericText? SchemeAssignedIdentification { get; init; }

    /// <summary>
    /// Business name of the acceptor.
    /// </summary>
    [IsoId("_8V_e27AREfCwE42C7pOZ8A")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_8V_e3bAREfCwE42C7pOZ8A")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Submitted address of the acceptor.
    /// </summary>
    [IsoId("_8V_e37AREfCwE42C7pOZ8A")]
    [DisplayName("Submitted Address")]
    [IsoXmlTag("SubmittdAdr")]
    public Address4? SubmittedAddress { get; init; }

    /// <summary>
    /// Applied or corrected address of the acceptor.
    /// </summary>
    [IsoId("_8V_e7bAREfCwE42C7pOZ8A")]
    [DisplayName("Applied Address")]
    [IsoXmlTag("ApldAdr")]
    public Address4? AppliedAddress { get; init; }

    /// <summary>
    /// Name and location of acceptor.
    /// </summary>
    [IsoId("_-qssarAREfCwE42C7pOZ8A")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public IsoMax99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("__2P5gbAREfCwE42C7pOZ8A")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Contains business registration Identification of the acceptor.
    /// </summary>
    [IsoId("_8V_e-7AREfCwE42C7pOZ8A")]
    [DisplayName("Business Registration Identification")]
    [IsoXmlTag("BizRegnId")]
    public IsoMax35Text? BusinessRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains the type of acceptor's business registration Identification.
    /// </summary>
    [IsoId("_8V_e_bAREfCwE42C7pOZ8A")]
    [DisplayName("Business Registration Identification Type")]
    [IsoXmlTag("BizRegnIdTp")]
    public IsoMax35Text? BusinessRegistrationIdentificationType { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_8V_e_7AREfCwE42C7pOZ8A")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData18> LocalData { get; init; } = [];

    /// <summary>
    /// Contains a code that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [IsoId("_8V_fAbAREfCwE42C7pOZ8A")]
    [DisplayName("Additional Transaction Reference Number")]
    [IsoXmlTag("AddtlTxRefNb")]
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; }

    /// <summary>
    /// Identifies a specific partnership agreement, generally between specific acceptors and issuers.
    /// </summary>
    [IsoId("_8V_fA7AREfCwE42C7pOZ8A")]
    [DisplayName("Partner Identification")]
    [IsoXmlTag("PrtnrId")]
    public IsoMax35Text? PartnerIdentification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_8V_fBbAREfCwE42C7pOZ8A")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_8V_fB7AREfCwE42C7pOZ8A")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
