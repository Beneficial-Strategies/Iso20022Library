// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a non-financial institution.
/// </summary>
[IsoId("_QEgDhtp-Ed-ak6NoX_4Aeg_-47216937")]
[DisplayName("Non Financial Institution Identification")]
public record NonFinancialInstitutionIdentification1
{
    /// <summary>
    /// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QEgDh9p-Ed-ak6NoX_4Aeg_763605927")]
    [DisplayName("BEI")]
    [IsoXmlTag("BEI")]
    [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
    public IsoBEIIdentifier? BEI { get; init; }

    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities or physical entities according to the European Association for Numbering (EAN) numbering scheme rules. The number is used to retrieve detailed information linked to it.
    /// </summary>
    [IsoId("_QEgDiNp-Ed-ak6NoX_4Aeg_764528561")]
    [DisplayName("EANGLN")]
    [IsoXmlTag("EANGLN")]
    [IsoSimpleType(IsoSimpleType.EANGLNIdentifier)]
    public IsoEANGLNIdentifier? EANGLN { get; init; }

    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_QEgDidp-Ed-ak6NoX_4Aeg_764528699")]
    [DisplayName("CHIPS Universal Identification")]
    [IsoXmlTag("USCHU")]
    [IsoSimpleType(IsoSimpleType.CHIPSUniversalIdentifier)]
    public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; }

    /// <summary>
    /// Data Universal Numbering System. A unique identification number provided by Dun &amp; Bradstreet to identify an organization.
    /// </summary>
    [IsoId("_QEgDitp-Ed-ak6NoX_4Aeg_794079445")]
    [DisplayName("DUNS")]
    [IsoXmlTag("DUNS")]
    [IsoSimpleType(IsoSimpleType.DunsIdentifier)]
    public IsoDunsIdentifier? DUNS { get; init; }

    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank to identify a relationship as defined between the bank and its client.
    /// </summary>
    [IsoId("_QEgDi9p-Ed-ak6NoX_4Aeg_854111585")]
    [DisplayName("Bank Party Identification")]
    [IsoXmlTag("BkPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BankPartyIdentification { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QEgDjNp-Ed-ak6NoX_4Aeg_196804779")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_QEp0gNp-Ed-ak6NoX_4Aeg_1659438900")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification3? ProprietaryIdentification { get; init; }
}
