// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a financial institution.
/// </summary>
[IsoId("_TE4ETNp-Ed-ak6NoX_4Aeg_1904039525")]
public interface IFinancialInstitutionIdentification8 : IIsoComponent
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_TE4ETdp-Ed-ak6NoX_4Aeg_-1044219164")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    BICFIIdentifier? BICFI { get; }

    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_TE4ETtp-Ed-ak6NoX_4Aeg_42141218")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    IClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; }

    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    [IsoId("_TE4ET9p-Ed-ak6NoX_4Aeg_1330079303")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_TE4EUNp-Ed-ak6NoX_4Aeg_-1638666214")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress6? PostalAddress { get; }

    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_TFB1QNp-Ed-ak6NoX_4Aeg_-280855258")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericFinancialIdentification1? Other { get; }
}
