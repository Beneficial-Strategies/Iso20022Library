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
/// Preparation/bringing to market of a security (also known as primary market or Initial Public Offering (IPO) issuance).
/// </summary>
[IsoId("_r6TOIWf2Eembv_9KtOEw8g")]
[DisplayName("Issuance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Issuance6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates where the financial instrument was issued.
    /// </summary>
    [IsoId("_sG_mUWf2Eembv_9KtOEw8g")]
    [DisplayName("Issue Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssePlc")]
    #endif
    [IsoXmlTag("IssePlc")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? IssuePlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuePlace { get; init; } 
    #else
    public System.String? IssuePlace { get; set; } 
    #endif
    
    /// <summary>
    /// Country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_sG_mX2f2Eembv_9KtOEw8g")]
    [DisplayName("Country Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIsse")]
    #endif
    [IsoXmlTag("CtryOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIssue { get; init; } 
    #else
    public string? CountryOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_sG_mZ2f2Eembv_9KtOEw8g")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time, as announced by the issuer, at which the securities will be issued.
    /// </summary>
    [IsoId("_sG_mb2f2Eembv_9KtOEw8g")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AnnouncementDate { get; init; } 
    #else
    public System.DateTime? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_sG_mcWf2Eembv_9KtOEw8g")]
    [DisplayName("Issuer Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrOrg")]
    #endif
    [IsoXmlTag("IssrOrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? IssuerOrganisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? IssuerOrganisation { get; init; } 
    #else
    public Organisation38? IssuerOrganisation { get; set; } 
    #endif
    
    /// <summary>
    /// Total original amount or quantity published.
    /// </summary>
    [IsoId("_sG_mc2f2Eembv_9KtOEw8g")]
    [DisplayName("Issue Nominal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseNmnlAmt")]
    #endif
    [IsoXmlTag("IsseNmnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? IssueNominalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? IssueNominalAmount { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? IssueNominalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Figure used as a control to verify whether the information provided is correct. It represents the issue size multiplied by the issue price.
    /// </summary>
    [IsoId("_sG_mdWf2Eembv_9KtOEw8g")]
    [DisplayName("Full Issued Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullIssdAmt")]
    #endif
    [IsoXmlTag("FullIssdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FullIssuedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FullIssuedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FullIssuedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the total amount/quantity of the proceeds from the sale of all securities in the initial offering. This amount/quantity is known after the new issue is priced.
    /// </summary>
    [IsoId("_sG_md2f2Eembv_9KtOEw8g")]
    [DisplayName("Issue Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseSz")]
    #endif
    [IsoXmlTag("IsseSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? IssueSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? IssueSize { get; init; } 
    #else
    public System.UInt64? IssueSize { get; set; } 
    #endif
    
    /// <summary>
    /// Initial issue price of the asset.
    /// </summary>
    [IsoId("_sG_meWf2Eembv_9KtOEw8g")]
    [DisplayName("Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssePric")]
    #endif
    [IsoXmlTag("IssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? IssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? IssuePrice { get; init; } 
    #else
    public PriceValue1? IssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Way in which the issue will be marketed to the primary market, via individual dealers (so called non syndicated distribution) or via a syndicate of managers, underwriters and selling group members (so called syndicated distribution).
    /// </summary>
    [IsoId("_sG_me2f2Eembv_9KtOEw8g")]
    [DisplayName("Issuance Distribution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncDstrbtn")]
    #endif
    [IsoXmlTag("IssncDstrbtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionType31Choice_? IssuanceDistribution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionType31Choice_? IssuanceDistribution { get; init; } 
    #else
    public SecuritiesTransactionType31Choice_? IssuanceDistribution { get; set; } 
    #endif
    
    /// <summary>
    /// Jurisdiction (country, county, state, province, city) of the issue.
    /// </summary>
    [IsoId("_sG_mfWf2Eembv_9KtOEw8g")]
    [DisplayName("Governing Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovngLaw")]
    #endif
    [IsoXmlTag("GovngLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Jurisdiction1? GoverningLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Jurisdiction1? GoverningLaw { get; init; } 
    #else
    public Jurisdiction1? GoverningLaw { get; set; } 
    #endif
    
    
    #nullable disable
    
}
