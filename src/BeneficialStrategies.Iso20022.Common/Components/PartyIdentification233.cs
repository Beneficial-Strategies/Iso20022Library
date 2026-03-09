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
[IsoId("_FEeukeXuEemEj48jhmlA0Q")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification233
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification233 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification233( PartyIdentification120Choice_ reqOwnerIdentification,FinancialInstrumentQuantity1Choice_ reqOwnedSecuritiesQuantity )
    {
        OwnerIdentification = reqOwnerIdentification;
        OwnedSecuritiesQuantity = reqOwnedSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_FWLileXuEemEj48jhmlA0Q")]
    [DisplayName("Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrId")]
    #endif
    [IsoXmlTag("OwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification120Choice_ OwnerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification120Choice_ OwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_ OwnerIdentification { get; init; } 
    #else
    public PartyIdentification120Choice_ OwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_FWLineXuEemEj48jhmlA0Q")]
    [DisplayName("LEI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEIId")]
    #endif
    [IsoXmlTag("LEIId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEIIdentification { get; init; } 
    #else
    public System.String? LEIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_FWLin-XuEemEj48jhmlA0Q")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification7? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_FWLip-XuEemEj48jhmlA0Q")]
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
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_FWLir-XuEemEj48jhmlA0Q")]
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
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_FWLit-XuEemEj48jhmlA0Q")]
    [DisplayName("Owned Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwndSctiesQty")]
    #endif
    [IsoXmlTag("OwndSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_FWLiv-XuEemEj48jhmlA0Q")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType10Choice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType10Choice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType10Choice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_NKqEIOXxEemEj48jhmlA0Q")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_FWLix-XuEemEj48jhmlA0Q")]
    [DisplayName("Certification Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnBrkdwn")]
    #endif
    [IsoXmlTag("CertfctnBrkdwn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CertificationBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationBreakdown { get; init; } 
    #else
    public System.String? CertificationBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
