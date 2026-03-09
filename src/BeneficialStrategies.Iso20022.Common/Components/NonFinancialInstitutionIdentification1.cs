// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a non-financial institution.
/// </summary>
[IsoId("_QEgDhtp-Ed-ak6NoX_4Aeg_-47216937")]
[DisplayName("Non Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialInstitutionIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QEgDh9p-Ed-ak6NoX_4Aeg_763605927")]
    [DisplayName("BEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BEI")]
    #endif
    [IsoXmlTag("BEI")]
    [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBEIIdentifier? BEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BEI { get; init; } 
    #else
    public System.String? BEI { get; set; } 
    #endif
    
    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities or physical entities according to the European Association for Numbering (EAN) numbering scheme rules. The number is used to retrieve detailed information linked to it.
    /// </summary>
    [IsoId("_QEgDiNp-Ed-ak6NoX_4Aeg_764528561")]
    [DisplayName("EANGLN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EANGLN")]
    #endif
    [IsoXmlTag("EANGLN")]
    [IsoSimpleType(IsoSimpleType.EANGLNIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoEANGLNIdentifier? EANGLN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EANGLN { get; init; } 
    #else
    public System.String? EANGLN { get; set; } 
    #endif
    
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_QEgDidp-Ed-ak6NoX_4Aeg_764528699")]
    [DisplayName("CHIPS Universal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="USCHU")]
    #endif
    [IsoXmlTag("USCHU")]
    [IsoSimpleType(IsoSimpleType.CHIPSUniversalIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CHIPSUniversalIdentification { get; init; } 
    #else
    public System.String? CHIPSUniversalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data Universal Numbering System. A unique identification number provided by Dun &amp; Bradstreet to identify an organization.
    /// </summary>
    [IsoId("_QEgDitp-Ed-ak6NoX_4Aeg_794079445")]
    [DisplayName("DUNS")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DUNS")]
    #endif
    [IsoXmlTag("DUNS")]
    [IsoSimpleType(IsoSimpleType.DunsIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDunsIdentifier? DUNS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DUNS { get; init; } 
    #else
    public System.String? DUNS { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank to identify a relationship as defined between the bank and its client.
    /// </summary>
    [IsoId("_QEgDi9p-Ed-ak6NoX_4Aeg_854111585")]
    [DisplayName("Bank Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkPtyId")]
    #endif
    [IsoXmlTag("BkPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BankPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BankPartyIdentification { get; init; } 
    #else
    public System.String? BankPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QEgDjNp-Ed-ak6NoX_4Aeg_196804779")]
    [DisplayName("Tax Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxIdNb")]
    #endif
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxIdentificationNumber { get; init; } 
    #else
    public System.String? TaxIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_QEp0gNp-Ed-ak6NoX_4Aeg_1659438900")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryId")]
    #endif
    [IsoXmlTag("PrtryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification3? ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification3? ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification3? ProprietaryIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
