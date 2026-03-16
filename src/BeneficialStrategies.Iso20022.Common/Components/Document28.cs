// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document28.
/// </summary>
[IsoId("_Jzrd8fgxEe-yU4gaFULAeA")]
[DisplayName("Document28")]
public partial record Document28
{
    #nullable enable

    /// <summary>
    /// Data Record.
    /// </summary>
    [DisplayName("Data Record")]
    [IsoXmlTag("DataRcrd")]
    public SupplementaryDataEnvelope1? DataRecord { get; init; } 

    /// <summary>
    /// Document Reference.
    /// </summary>
    [DisplayName("Document Reference")]
    [IsoXmlTag("DocRef")]
    public ValueList<Document26> DocumentReference { get; init; } = [];

    /// <summary>
    /// Historical Data.
    /// </summary>
    [DisplayName("Historical Data")]
    [IsoXmlTag("HstrclData")]
    public IsoTrueFalseIndicator? HistoricalData { get; init; } 

    /// <summary>
    /// Home Country.
    /// </summary>
    [DisplayName("Home Country")]
    [IsoXmlTag("HomeCtry")]
    public CountryCode? HomeCountry { get; init; } 

    /// <summary>
    /// Host Country.
    /// </summary>
    [DisplayName("Host Country")]
    [IsoXmlTag("HstCtry")]
    public ValueList<CountryCode> HostCountry { get; init; } = [];

    /// <summary>
    /// Personal Data.
    /// </summary>
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    public IsoTrueFalseIndicator? PersonalData { get; init; } 

    /// <summary>
    /// Publication Period.
    /// </summary>
    [DisplayName("Publication Period")]
    [IsoXmlTag("PblctnPrd")]
    public Period4Choice_? PublicationPeriod { get; init; } 

    /// <summary>
    /// Regulatory Data Type.
    /// </summary>
    [DisplayName("Regulatory Data Type")]
    [IsoXmlTag("RgltryDataTp")]
    public ValueList<ClassificationType4> RegulatoryDataType { get; init; } = [];

    /// <summary>
    /// Related Entity.
    /// </summary>
    [DisplayName("Related Entity")]
    [IsoXmlTag("RltdNtty")]
    public ValueList<PartyIdentification260Choice_> RelatedEntity { get; init; } = [];

    /// <summary>
    /// Related Period.
    /// </summary>
    [DisplayName("Related Period")]
    [IsoXmlTag("RltdPrd")]
    public Period4Choice_? RelatedPeriod { get; init; } 

    /// <summary>
    /// Related Product Identifier.
    /// </summary>
    [DisplayName("Related Product Identifier")]
    [IsoXmlTag("RltdPdctIdr")]
    public ValueList<SecurityIdentification49> RelatedProductIdentifier { get; init; } = [];

    /// <summary>
    /// Related Regulatory Data.
    /// </summary>
    [DisplayName("Related Regulatory Data")]
    [IsoXmlTag("RltdRgltryData")]
    public ValueList<GenericIdentification190> RelatedRegulatoryData { get; init; } = [];

    /// <summary>
    /// Submission Date Time.
    /// </summary>
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    public IsoISODateTime? SubmissionDateTime { get; init; } 

    /// <summary>
    /// Submission Type.
    /// </summary>
    [DisplayName("Submission Type")]
    [IsoXmlTag("SubmissnTp")]
    public TransactionOperationType13Code? SubmissionType { get; init; } 

    /// <summary>
    /// Technical Record Identifier.
    /// </summary>
    [DisplayName("Technical Record Identifier")]
    [IsoXmlTag("TechRcrdIdr")]
    public IsoMax140Text? TechnicalRecordIdentifier { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoPositiveNumber? Version { get; init; } 

    /// <summary>
    /// Voluntary.
    /// </summary>
    [DisplayName("Voluntary")]
    [IsoXmlTag("Vlntry")]
    public IsoTrueFalseIndicator? Voluntary { get; init; } 

    
    #nullable disable
    
}
