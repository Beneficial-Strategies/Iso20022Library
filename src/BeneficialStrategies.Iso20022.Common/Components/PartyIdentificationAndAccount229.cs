// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification And Account229.
/// </summary>
[IsoId("_3hKNm5IOEe-HRNGM304Vlw")]
[DisplayName("Party Identification And Account229")]
public record PartyIdentificationAndAccount229
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Contact Person.
    /// </summary>
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification254Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Processing Date.
    /// </summary>
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Processing Identification.
    /// </summary>
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Sub Account.
    /// </summary>
    [DisplayName("Sub Account")]
    [IsoXmlTag("SubAcct")]
    public SubAccount4? SubAccount { get; init; }
}
