// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of travel document used for identification and/or authentication of the customer.
/// </summary>
[IsoId("_B0MHEFzHEeeDqe2giKl0eQ")]
[DisplayName("Travel Document")]
public record TravelDocument1
{
    /// <summary>
    /// Type of travel document.
    /// </summary>
    [IsoId("_PMPGQFzHEeeDqe2giKl0eQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OfficialDocumentType1Code Type { get; init; }

    /// <summary>
    /// Form of travel document.
    /// </summary>
    [IsoId("_WTxwsFzHEeeDqe2giKl0eQ")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; }

    /// <summary>
    /// Identification of travel document (for example, passport number).
    /// </summary>
    [IsoId("_cpofgFzHEeeDqe2giKl0eQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Party assigning the travel document.
    /// </summary>
    [IsoId("_i476YFzHEeeDqe2giKl0eQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Assigner { get; init; }

    /// <summary>
    /// Issuance date of travel document.
    /// </summary>
    [IsoId("_o3I-MFzHEeeDqe2giKl0eQ")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of travel document (if and when relevant).
    /// </summary>
    [IsoId("_ttx9AFzHEeeDqe2giKl0eQ")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the travel document.
    /// </summary>
    [IsoId("_3hAxoFzHEeeDqe2giKl0eQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }
}
