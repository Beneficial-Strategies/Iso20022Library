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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_O07nJ5S8EemqYPWMBuVawg")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument87
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument87 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument87( SecurityIdentification25Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    [IsoId("_PI3PxZS8EemqYPWMBuVawg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification25Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification25Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_PI3Px5S8EemqYPWMBuVawg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_PI3Pz5S8EemqYPWMBuVawg")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_PI3P0ZS8EemqYPWMBuVawg")]
    [DisplayName("Supplementary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryId")]
    #endif
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupplementaryIdentification { get; init; } 
    #else
    public System.String? SupplementaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by the fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_PI3P05S8EemqYPWMBuVawg")]
    [DisplayName("Class Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssTp")]
    #endif
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_PI3P1ZS8EemqYPWMBuVawg")]
    [DisplayName("Securities Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesForm")]
    #endif
    [IsoXmlTag("SctiesForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecuritiesForm { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_PI3P3ZS8EemqYPWMBuVawg")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_PI3P35S8EemqYPWMBuVawg")]
    [DisplayName("Product Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctGrp")]
    #endif
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductGroup { get; init; } 
    #else
    public System.String? ProductGroup { get; set; } 
    #endif
    
    /// <summary>
    /// When an account at fund or security level is blocked, this specifies details on how the holding is blocked.
    /// </summary>
    [IsoId("_PI3P4ZS8EemqYPWMBuVawg")]
    [DisplayName("Blocked Holding Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdHldgDtls")]
    #endif
    [IsoXmlTag("BlckdHldgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; init; } 
    #else
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_PI3P45S8EemqYPWMBuVawg")]
    [DisplayName("Pledging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pldgg")]
    #endif
    [IsoXmlTag("Pldgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Eligible1Code? Pledging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Eligible1Code? Pledging { get; init; } 
    #else
    public Eligible1Code? Pledging { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_PI3P5ZS8EemqYPWMBuVawg")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Collateral1Code? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral1Code? Collateral { get; init; } 
    #else
    public Collateral1Code? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_PI3P55S8EemqYPWMBuVawg")]
    [DisplayName("Third Party Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPtyRghts")]
    #endif
    [IsoXmlTag("ThrdPtyRghts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThirdPartyRights2? ThirdPartyRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThirdPartyRights2? ThirdPartyRights { get; init; } 
    #else
    public ThirdPartyRights2? ThirdPartyRights { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if all the shares are owned exclusively by the fund company.
    /// </summary>
    [IsoId("_PI3P6ZS8EemqYPWMBuVawg")]
    [DisplayName("Fund Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndOwnrsh")]
    #endif
    [IsoXmlTag("FndOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundOwnership1Code? FundOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOwnership1Code? FundOwnership { get; init; } 
    #else
    public FundOwnership1Code? FundOwnership { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the fund is intended for qualified investors.
    /// </summary>
    [IsoId("_PI3P65S8EemqYPWMBuVawg")]
    [DisplayName("Fund Intention")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndIntntn")]
    #endif
    [IsoXmlTag("FndIntntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundIntention1Code? FundIntention { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundIntention1Code? FundIntention { get; init; } 
    #else
    public FundIntention1Code? FundIntention { get; set; } 
    #endif
    
    /// <summary>
    /// Operational status of the fund.
    /// </summary>
    [IsoId("_PI3P7ZS8EemqYPWMBuVawg")]
    [DisplayName("Operational Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlSts")]
    #endif
    [IsoXmlTag("OprlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OperationalStatus1Code? OperationalStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OperationalStatus1Code? OperationalStatus { get; init; } 
    #else
    public OperationalStatus1Code? OperationalStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
