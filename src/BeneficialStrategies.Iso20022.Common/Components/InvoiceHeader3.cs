// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collection of data for that is exchanged between two or more parties in written, printed or electronic form.
/// </summary>
[IsoId("_xV7LweWoEeevU7McUP3D1w")]
[DisplayName("Invoice Header")]
public record InvoiceHeader3
{
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    [IsoId("_xepp8eWoEeevU7McUP3D1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_xepp8-WoEeevU7McUP3D1w")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    public required ExternalDocumentType1Code TypeCode { get; init; }

    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_xeqRAeWoEeevU7McUP3D1w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_xeqRA-WoEeevU7McUP3D1w")]
    [DisplayName("Issue Date Time")]
    [IsoXmlTag("IsseDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime IssueDateTime { get; init; }

    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    [IsoId("_xeqRBeWoEeevU7McUP3D1w")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public TradeParty4? Issuer { get; init; }

    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    [IsoId("_xeqRB-WoEeevU7McUP3D1w")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    [IsoId("_xeqRCeWoEeevU7McUP3D1w")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CopyIndicator { get; init; }

    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    [IsoId("_xeqRC-WoEeevU7McUP3D1w")]
    [DisplayName("Document Purpose")]
    [IsoXmlTag("DocPurp")]
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; }

    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    [IsoId("_xeqRDeWoEeevU7McUP3D1w")]
    [DisplayName("Included Note")]
    [IsoXmlTag("InclNote")]
    public AdditionalInformation6? IncludedNote { get; init; }
}
