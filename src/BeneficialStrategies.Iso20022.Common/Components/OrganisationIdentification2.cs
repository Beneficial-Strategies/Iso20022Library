// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_QQa_pNp-Ed-ak6NoX_4Aeg_-987207025")]
[DisplayName("Organisation Identification")]
public partial record OrganisationIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QQa_pdp-Ed-ak6NoX_4Aeg_-916094981")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public IsoBICIdentifier? BIC { get; init; } 
    
    /// <summary>
    /// International Business Entity Identifier to uniquely identify business entities playing a role in the lifecycle of and events related to a financial instrument. (tentative - to be confirmed).
    /// </summary>
    [IsoId("_QQa_ptp-Ed-ak6NoX_4Aeg_-857912325")]
    [DisplayName("IBEI")]
    [IsoXmlTag("IBEI")]
    [IsoSimpleType(IsoSimpleType.IBEIIdentifier)]
    public IsoIBEIIdentifier? IBEI { get; init; } 
    
    /// <summary>
    /// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QQa_p9p-Ed-ak6NoX_4Aeg_-987206748")]
    [DisplayName("BEI")]
    [IsoXmlTag("BEI")]
    [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
    public IsoBEIIdentifier? BEI { get; init; } 
    
    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities, or physical entities according to the European Association for Numbering (EAN) numbering scheme rules.The number is used to retrieve detailed information that is linked to it.
    /// </summary>
    [IsoId("_QQa_qNp-Ed-ak6NoX_4Aeg_-987206671")]
    [DisplayName("EANGLN")]
    [IsoXmlTag("EANGLN")]
    [IsoSimpleType(IsoSimpleType.EANGLNIdentifier)]
    public IsoEANGLNIdentifier? EANGLN { get; init; } 
    
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_QQkwoNp-Ed-ak6NoX_4Aeg_-987206611")]
    [DisplayName("CHIPS Universal Identification")]
    [IsoXmlTag("USCHU")]
    [IsoSimpleType(IsoSimpleType.CHIPSUniversalIdentifier)]
    public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; } 
    
    /// <summary>
    /// Data Universal Numbering System. A unique identification number provided by Dun &amp; Bradstreet to identify an organization.
    /// </summary>
    [IsoId("_QQkwodp-Ed-ak6NoX_4Aeg_-987206285")]
    [DisplayName("DUNS")]
    [IsoXmlTag("DUNS")]
    [IsoSimpleType(IsoSimpleType.DunsIdentifier)]
    public IsoDunsIdentifier? DUNS { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank to identify a relationship as defined between the bank and its client.
    /// </summary>
    [IsoId("_QQkwotp-Ed-ak6NoX_4Aeg_-987206225")]
    [DisplayName("Bank Party Identification")]
    [IsoXmlTag("BkPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BankPartyIdentification { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QQkwo9p-Ed-ak6NoX_4Aeg_-987206148")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_QQkwpNp-Ed-ak6NoX_4Aeg_-987206069")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification3? ProprietaryIdentification { get; init; } 
    
    
    #nullable disable
    
}
