// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the beneficial owner of the securities.
/// </summary>
[IsoId("_UDK4gtp-Ed-ak6NoX_4Aeg_988649524")]
[DisplayName("Beneficial Owner")]
public partial record BeneficialOwner1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    [IsoId("_UDK4g9p-Ed-ak6NoX_4Aeg_1334046666")]
    [DisplayName("Beneficial Owner Identification")]
    [IsoXmlTag("BnfclOwnrId")]
    public required PartyIdentification2Choice_ BeneficialOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Additional identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    [IsoId("_UDK4hNp-Ed-ak6NoX_4Aeg_676441952")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public GenericIdentification16? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Nationality of the beneficial owner.
    /// </summary>
    [IsoId("_UDK4hdp-Ed-ak6NoX_4Aeg_1121599543")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; } 
    
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a persons permanent home).
    /// </summary>
    [IsoId("_UDK4htp-Ed-ak6NoX_4Aeg_-2035918764")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; } 
    
    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_UDK4h9p-Ed-ak6NoX_4Aeg_-1915021119")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public CountryCode? NonDomicileCountry { get; init; } 
    
    /// <summary>
    /// Whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    [IsoId("_UDK4iNp-Ed-ak6NoX_4Aeg_1671667903")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UDK4idp-Ed-ak6NoX_4Aeg_1671667933")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, eg, beneficial ownership.
    /// </summary>
    [IsoId("_UDK4itp-Ed-ak6NoX_4Aeg_1438879300")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UDUCcNp-Ed-ak6NoX_4Aeg_1039620249")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of securities elected by to the beneficial owner.
    /// </summary>
    [IsoId("_UDUCcdp-Ed-ak6NoX_4Aeg_1538417422")]
    [DisplayName("Elected Securities Quantity")]
    [IsoXmlTag("ElctdSctiesQty")]
    public required UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; init; } 
    
    
    #nullable disable
    
}
