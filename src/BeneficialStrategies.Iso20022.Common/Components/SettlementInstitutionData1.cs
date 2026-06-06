// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a settlement institution.
/// </summary>
[IsoId("_VzJBwXSBEfC68Y4jZPNEug")]
[DisplayName("Settlement Institution Data1")]
public record SettlementInstitutionData1
{
    /// <summary>
    /// Identification of the settlement institution.
    /// </summary>
    [IsoId("_V1r_cXSBEfC68Y4jZPNEug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    /// <summary>
    /// Business or client identification for settlement institution.
    /// </summary>
    [IsoId("_pLpHgXSBEfC68Y4jZPNEug")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_V1r_e3SBEfC68Y4jZPNEug")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Business name of the settlement institution.
    /// </summary>
    [IsoId("_V1r_fXSBEfC68Y4jZPNEug")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the settlement institution.
    /// </summary>
    [IsoId("_V1r_f3SBEfC68Y4jZPNEug")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address of the settlement institution.
    /// </summary>
    [IsoId("_8g0MenSBEfC68Y4jZPNEug")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_8g0Me3SBEfC68Y4jZPNEug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_8g0MfHSBEfC68Y4jZPNEug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_8g0MfXSBEfC68Y4jZPNEug")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
