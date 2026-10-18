// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details to identify a financial institution.
/// </summary>
[IsoId("_8xXCNW49EeiU9cctagi5ow")]
public interface IFinancialInstitutionIdentification18 : IIsoComponent
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_87o_kW49EeiU9cctagi5ow")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    BICFIDec2014Identifier? BICFI { get; }

    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_87o_k249EeiU9cctagi5ow")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    IClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; }

    /// <summary>
    /// Legal entity identifier of the financial institution.
    /// </summary>
    [IsoId("_b1ZcUXRwEeiH1ZOt2UD8vQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    LEIIdentifier? LEI { get; }

    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    [IsoId("_87o_lW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_87o_l249EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress24? PostalAddress { get; }

    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_87o_mW49EeiU9cctagi5ow")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericFinancialIdentification1? Other { get; }
}
