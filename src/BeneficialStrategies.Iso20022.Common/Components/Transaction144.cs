// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_vB-boTNJEeylu6lH-gut-A")]
[DisplayName("Transaction")]
public record Transaction144
{
    /// <summary>
    /// Code that identifies an administrative type.
    /// </summary>
    [IsoId("_EakJ0DNKEeylu6lH-gut-A")]
    [DisplayName("Administrative Type")]
    [IsoXmlTag("AdmstvTp")]
    public required AdministrativeType1Code AdministrativeType { get; init; }

    /// <summary>
    /// Other administrative type defined at private or national level.
    /// </summary>
    [IsoId("_gcgVIDNLEeylu6lH-gut-A")]
    [DisplayName("Other Administrative Type")]
    [IsoXmlTag("OthrAdmstvTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherAdministrativeType { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_vIt83zNJEeylu6lH-gut-A")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_vIt87TNJEeylu6lH-gut-A")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_vIt88TNJEeylu6lH-gut-A")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_vIt88zNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Indicator")]
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_vIt89TNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_vIt89zNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_vIt8-TNJEeylu6lH-gut-A")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_vIt8-zNJEeylu6lH-gut-A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; }

    /// <summary>
    /// Contains generic text message.
    /// </summary>
    [IsoId("_8Q3z8DNLEeylu6lH-gut-A")]
    [DisplayName("Text Message")]
    [IsoXmlTag("TxtMsg")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20KText? TextMessage { get; init; }

    /// <summary>
    /// Additional Information in local language.
    /// </summary>
    [IsoId("_NCW0IDNMEeylu6lH-gut-A")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData9> LocalData { get; init; } = [];

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_vIt9ITNJEeylu6lH-gut-A")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_vIt9IzNJEeylu6lH-gut-A")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData2> AdditionalData { get; init; } = [];
}
