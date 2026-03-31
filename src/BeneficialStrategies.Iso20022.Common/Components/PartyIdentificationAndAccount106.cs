// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_Cm3UsR5dEeWE3PufGMdJ3w")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount106
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_DGP_ZR5dEeWE3PufGMdJ3w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification71Choice_ Identification { get; init; }

    /// <summary>
    /// Legal Entity Identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_SyURQGwdEeWLq_lbZ2Mhyw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_DGP_bR5dEeWE3PufGMdJ3w")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_DGP_dR5dEeWE3PufGMdJ3w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount24? SafekeepingAccount { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_DGP_fR5dEeWE3PufGMdJ3w")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_DGP_hR5dEeWE3PufGMdJ3w")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_DGP_jR5dEeWE3PufGMdJ3w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
