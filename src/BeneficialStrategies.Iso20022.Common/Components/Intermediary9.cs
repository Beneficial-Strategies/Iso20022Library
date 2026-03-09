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
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_QN5QFtp-Ed-ak6NoX_4Aeg_-1242436209")]
[DisplayName("Intermediary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Intermediary9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Intermediary9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Intermediary9( PartyIdentification2Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QN5QF9p-Ed-ak6NoX_4Aeg_-1242436191")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ Identification { get; init; } 
    #else
    public PartyIdentification2Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QN5QGNp-Ed-ak6NoX_4Aeg_-1242436053")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account7? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account7? Account { get; init; } 
    #else
    public Account7? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_QOCaANp-Ed-ak6NoX_4Aeg_-1242436131")]
    [DisplayName("Order Originator Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrOrgtrElgblty")]
    #endif
    [IsoXmlTag("OrdrOrgtrElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    #else
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Capacity of the party executing an order.
    /// </summary>
    [IsoId("_QOCaAdp-Ed-ak6NoX_4Aeg_1361094241")]
    [DisplayName("Trading Party Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPtyCpcty")]
    #endif
    [IsoXmlTag("TradgPtyCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingCapacity2Code? TradingPartyCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity2Code? TradingPartyCapacity { get; init; } 
    #else
    public TradingCapacity2Code? TradingPartyCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOCaAtp-Ed-ak6NoX_4Aeg_-1242436166")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundRole2Code? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundRole2Code? Role { get; init; } 
    #else
    public InvestmentFundRole2Code? Role { get; set; } 
    #endif
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOCaA9p-Ed-ak6NoX_4Aeg_-1242436149")]
    [DisplayName("Extended Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedRole")]
    #endif
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedRole { get; init; } 
    #else
    public System.String? ExtendedRole { get; set; } 
    #endif
    
    
    #nullable disable
    
}
