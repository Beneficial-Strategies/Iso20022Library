// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, a financial institution or a non-financial institution.
/// </summary>
[IsoId("_PZleRNp-Ed-ak6NoX_4Aeg_-704103570")]
[DisplayName("Party Identification")]
public record PartyIdentification8
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PZleRdp-Ed-ak6NoX_4Aeg_-704103526")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_PZleRtp-Ed-ak6NoX_4Aeg_-704103466")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress1? PostalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous way of identifying an organisation or an individual person.
    /// </summary>
    [IsoId("_PZleR9p-Ed-ak6NoX_4Aeg_-704102561")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party2Choice_? Identification { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_PZleSNp-Ed-ak6NoX_4Aeg_1082909095")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }
}
