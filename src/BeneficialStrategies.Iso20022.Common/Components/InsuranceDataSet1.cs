// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Formal document used to record a fact and used as proof of the fact that goods have been insured under an insurance policy.
/// </summary>
[IsoId("_Tm2v9tp-Ed-ak6NoX_4Aeg_888710434")]
[DisplayName("Insurance Data Set")]
public record InsuranceDataSet1
{
    /// <summary>
    /// Identifies the insurancedata set.
    /// </summary>
    [IsoId("_Tm2v99p-Ed-ak6NoX_4Aeg_-1099246738")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Issuer of the certificate, typically the insurance company or its agent.
    /// </summary>
    [IsoId("_Tm2v-Np-Ed-ak6NoX_4Aeg_1216560686")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification26 Issuer { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_Tm2v-dp-Ed-ak6NoX_4Aeg_1545335745")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Date upon which cover under an insurance policy becomes effective.
    /// </summary>
    [IsoId("_Tm2v-tp-Ed-ak6NoX_4Aeg_1571192429")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDate { get; init; }

    /// <summary>
    /// Place where the insurance certificate was issued.
    /// </summary>
    [IsoId("_Tm2v-9p-Ed-ak6NoX_4Aeg_1690329886")]
    [DisplayName("Place Of Issue")]
    [IsoXmlTag("PlcOfIsse")]
    public PostalAddress5? PlaceOfIssue { get; init; }

    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_Tm2v_Np-Ed-ak6NoX_4Aeg_1786375668")]
    [DisplayName("Insurance Document Identification")]
    [IsoXmlTag("InsrncDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InsuranceDocumentIdentification { get; init; }

    /// <summary>
    /// Transport information relative to the goods that are insured under the insurance policy.
    /// </summary>
    [IsoId("_Tm_54Np-Ed-ak6NoX_4Aeg_-1469580210")]
    [DisplayName("Transport")]
    [IsoXmlTag("Trnsprt")]
    public SingleTransport3? Transport { get; init; }

    /// <summary>
    /// Value of the goods as insured under the insurance policy.
    /// </summary>
    [IsoId("_Tm_54dp-Ed-ak6NoX_4Aeg_-397424452")]
    [DisplayName("Insured Amount")]
    [IsoXmlTag("InsrdAmt")]
    public required CurrencyAndAmount InsuredAmount { get; init; }

    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_Tm_54tp-Ed-ak6NoX_4Aeg_-88042726")]
    [DisplayName("Insured Goods Description")]
    [IsoXmlTag("InsrdGoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? InsuredGoodsDescription { get; init; }

    /// <summary>
    /// Description of the conditions and exclusion clauses under which insurance is granted.
    /// </summary>
    [IsoId("_Tm_549p-Ed-ak6NoX_4Aeg_515013339")]
    [DisplayName("Insurance Conditions")]
    [IsoXmlTag("InsrncConds")]
    public SimpleValueList<IsoMax350Text> InsuranceConditions { get; init; } = [];

    /// <summary>
    /// Standard insurance clauses defined by the Institute of London Underwriters (or the American Institute of marine Underwriters).
    /// </summary>
    [IsoId("_Tm_55Np-Ed-ak6NoX_4Aeg_812386949")]
    [DisplayName("Insurance Clauses")]
    [IsoXmlTag("InsrncClauses")]
    public SimpleValueList<InsuranceClauses1Code> InsuranceClauses { get; init; } = [];

    /// <summary>
    /// Party that is covered under the assurance policy.
    /// </summary>
    [IsoId("_Tm_55dp-Ed-ak6NoX_4Aeg_976774092")]
    [DisplayName("Assured")]
    [IsoXmlTag("Assrd")]
    public required PartyIdentification29Choice_ Assured { get; init; }

    /// <summary>
    /// Place where claims under the insurance policy will be paid.
    /// </summary>
    [IsoId("_Tm_55tp-Ed-ak6NoX_4Aeg_1330485176")]
    [DisplayName("Claims Payable At")]
    [IsoXmlTag("ClmsPyblAt")]
    public required PostalAddress5 ClaimsPayableAt { get; init; }

    /// <summary>
    /// Currency in which claims, if valid, will be paid.
    /// </summary>
    [IsoId("_Tm_559p-Ed-ak6NoX_4Aeg_1343411929")]
    [DisplayName("Claims Payable In")]
    [IsoXmlTag("ClmsPyblIn")]
    public CurrencyCode? ClaimsPayableIn { get; init; }
}
