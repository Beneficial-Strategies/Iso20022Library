// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyIdentification8"/>
[IsoId("_PZleRNp-Ed-ak6NoX_4Aeg_-704103570")]
[DisplayName("Party Identification")]
public partial record PartyIdentification8
{
    /// <inheritdoc cref="IPartyIdentification8.Name"/>
    [IsoId("_PZleRdp-Ed-ak6NoX_4Aeg_-704103526")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <inheritdoc cref="IPartyIdentification8.PostalAddress"/>
    [IsoId("_PZleRtp-Ed-ak6NoX_4Aeg_-704103466")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress1? PostalAddress { get; init; }

    /// <inheritdoc cref="IPartyIdentification8.Identification"/>
    [IsoId("_PZleR9p-Ed-ak6NoX_4Aeg_-704102561")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party2Choice_? Identification { get; init; }

    /// <inheritdoc cref="IPartyIdentification8.CountryOfResidence"/>
    [IsoId("_PZleSNp-Ed-ak6NoX_4Aeg_1082909095")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }
}
