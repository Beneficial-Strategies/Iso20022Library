// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party6Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_Pa7iFdp-Ed-ak6NoX_4Aeg_926343088")]
public interface IOrganisationIdentification : IParty6Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Code allocated to a financial institution or non financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QRBcldp-Ed-ak6NoX_4Aeg_-1009093512")]
    [DisplayName("BIC Or BEI")]
    [IsoXmlTag("BICOrBEI")]
    IsoAnyBICIdentifier? BICOrBEI { get; }

    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_QRBcltp-Ed-ak6NoX_4Aeg_-1009092905")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericOrganisationIdentification1? Other { get; }
}
