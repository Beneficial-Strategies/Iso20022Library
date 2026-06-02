// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy.
/// </summary>
[IsoId("89c234be-72e5-452b-971e-52c1cc3c5190")]
[DisplayName("Financial Instrument107")]
public record FinancialInstrument107
{
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    [IsoId("8e5a4196-658c-4dbe-b7b2-a03d8fd068ce")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification46Choice Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("9fc43bb6-10c6-4dbc-8754-b06f4952e4bb")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("7ac15529-1275-4dcb-b15c-ab5a10d42ddf")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about the financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("2eef025f-2727-4de8-a67e-205b9aa85b00")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by the fund.
    /// </summary>
    [IsoId("6872bca5-3302-4ca8-8a9a-248d7a80bb98")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security.
    /// </summary>
    [IsoId("4fc23d33-85fe-4815-9445-afe045808778")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type.
    /// </summary>
    [IsoId("6d1bed1e-4a51-4346-9522-391cecb51e59")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("52e636cb-179f-49aa-adaa-d9e541eb8e1a")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// Choice of formats for the identification of a series.
    /// </summary>
    [IsoId("9c0091e5-691d-48e2-af00-d4d6978b8027")]
    [DisplayName("Series Identification")]
    [IsoXmlTag("SrsId")]
    public Series1? SeriesIdentification { get; init; }
}
