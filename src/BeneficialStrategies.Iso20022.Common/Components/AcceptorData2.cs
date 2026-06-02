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
[IsoId("_RMI-0SRbEfCa6bxMAKEOKg")]
[DisplayName("Acceptor Data2")]
public record AcceptorData2
{
    /// <summary>
    /// Identification of the acceptor.
    /// </summary>
    [IsoId("_ROqHUSRbEfCa6bxMAKEOKg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification to the acceptor assigned by the scheme.
    /// </summary>
    [IsoId("_ROqHWSRbEfCa6bxMAKEOKg")]
    [DisplayName("Scheme Assigned Identification")]
    [IsoXmlTag("SchmeAssgndId")]
    public IsoMax15AlphaNumericText? SchemeAssignedIdentification { get; init; }

    /// <summary>
    /// Business name of the acceptor.
    /// </summary>
    [IsoId("_ROqHWyRbEfCa6bxMAKEOKg")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_ROqHXSRbEfCa6bxMAKEOKg")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Submitted address of the acceptor.
    /// </summary>
    [IsoId("_ROqHcyRbEfCa6bxMAKEOKg")]
    [DisplayName("Submitted Address")]
    [IsoXmlTag("SubmittdAdr")]
    public Address4? SubmittedAddress { get; init; }

    /// <summary>
    /// Applied or corrected address of the acceptor.
    /// </summary>
    [IsoId("_4NAyVyRbEfCa6bxMAKEOKg")]
    [DisplayName("Applied Address")]
    [IsoXmlTag("ApldAdr")]
    public Address4? AppliedAddress { get; init; }

    /// <summary>
    /// Contains business registration Identification of the acceptor.
    /// </summary>
    [IsoId("_ROqHsSRbEfCa6bxMAKEOKg")]
    [DisplayName("Business Registration Identification")]
    [IsoXmlTag("BizRegnId")]
    public IsoMax35Text? BusinessRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains the type of acceptor's business registration Identification.
    /// </summary>
    [IsoId("_e83HQSRcEfCa6bxMAKEOKg")]
    [DisplayName("Business Registration Identification Type")]
    [IsoXmlTag("BizRegnIdTp")]
    public IsoMax35Text? BusinessRegistrationIdentificationType { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_ROqHtSRbEfCa6bxMAKEOKg")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData18> LocalData { get; init; } = [];

    /// <summary>
    /// Contains a code that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [IsoId("_ROqHtyRbEfCa6bxMAKEOKg")]
    [DisplayName("Additional Transaction Reference Number")]
    [IsoXmlTag("AddtlTxRefNb")]
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; }

    /// <summary>
    /// Identifies a specific partnership agreement, generally between specific acceptors and issuers.
    /// </summary>
    [IsoId("_ROqHzSRbEfCa6bxMAKEOKg")]
    [DisplayName("Partner Identification")]
    [IsoXmlTag("PrtnrId")]
    public IsoMax35Text? PartnerIdentification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_dWtcAmvdEfCyxsm1jzUNug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_dWtcA2vdEfCyxsm1jzUNug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
