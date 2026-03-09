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
/// Provides information about the beneficial owner of the securities.
/// </summary>
[IsoId("_UDK4gtp-Ed-ak6NoX_4Aeg_988649524")]
[DisplayName("Beneficial Owner")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BeneficialOwner1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BeneficialOwner1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BeneficialOwner1( PartyIdentification2Choice_ reqBeneficialOwnerIdentification,UnitOrFaceAmount1Choice_ reqElectedSecuritiesQuantity )
    {
        BeneficialOwnerIdentification = reqBeneficialOwnerIdentification;
        ElectedSecuritiesQuantity = reqElectedSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    [IsoId("_UDK4g9p-Ed-ak6NoX_4Aeg_1334046666")]
    [DisplayName("Beneficial Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrId")]
    #endif
    [IsoXmlTag("BnfclOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ BeneficialOwnerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ BeneficialOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ BeneficialOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ BeneficialOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    [IsoId("_UDK4hNp-Ed-ak6NoX_4Aeg_676441952")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification16? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification16? AdditionalIdentification { get; init; } 
    #else
    public GenericIdentification16? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Nationality of the beneficial owner.
    /// </summary>
    [IsoId("_UDK4hdp-Ed-ak6NoX_4Aeg_1121599543")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Nationality { get; init; } 
    #else
    public string? Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a persons permanent home).
    /// </summary>
    [IsoId("_UDK4htp-Ed-ak6NoX_4Aeg_-2035918764")]
    [DisplayName("Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmclCtry")]
    #endif
    [IsoXmlTag("DmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? DomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DomicileCountry { get; init; } 
    #else
    public string? DomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_UDK4h9p-Ed-ak6NoX_4Aeg_-1915021119")]
    [DisplayName("Non Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonDmclCtry")]
    #endif
    [IsoXmlTag("NonDmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? NonDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NonDomicileCountry { get; init; } 
    #else
    public string? NonDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    [IsoId("_UDK4iNp-Ed-ak6NoX_4Aeg_1671667903")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIndicator { get; init; } 
    #else
    public System.String? CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UDK4idp-Ed-ak6NoX_4Aeg_1671667933")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, eg, beneficial ownership.
    /// </summary>
    [IsoId("_UDK4itp-Ed-ak6NoX_4Aeg_1438879300")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclarationDetails { get; init; } 
    #else
    public System.String? DeclarationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UDUCcNp-Ed-ak6NoX_4Aeg_1039620249")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities elected by to the beneficial owner.
    /// </summary>
    [IsoId("_UDUCcdp-Ed-ak6NoX_4Aeg_1538417422")]
    [DisplayName("Elected Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctdSctiesQty")]
    #endif
    [IsoXmlTag("ElctdSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
