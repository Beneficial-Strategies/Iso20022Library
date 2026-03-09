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
/// Agreement between two parties to sell a financial instrument or set of financial instruments and repurchase at an agreed later date.
/// </summary>
[IsoId("_onOhMbJVEeaYqc4G3TTwhA")]
[DisplayName("Repurchase Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RepurchaseAgreement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RepurchaseAgreement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RepurchaseAgreement2( System.DateOnly reqMaturityDate,ActiveCurrencyAndAmount reqSecondLegPrice,ActiveCurrencyAndAmount reqCollateralMarketValue,System.String reqCounterparty,RepurchaseAgreementType3Choice_ reqRepurchaseAgreementType )
    {
        MaturityDate = reqMaturityDate;
        SecondLegPrice = reqSecondLegPrice;
        CollateralMarketValue = reqCollateralMarketValue;
        Counterparty = reqCounterparty;
        RepurchaseAgreementType = reqRepurchaseAgreementType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the repurchase agreement matures.
    /// </summary>
    [IsoId("_oxf3gbJVEeaYqc4G3TTwhA")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate MaturityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly MaturityDate { get; init; } 
    #else
    public System.DateOnly MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the repurchase price at maturity of the repo.
    /// </summary>
    [IsoId("_oxf3g7JVEeaYqc4G3TTwhA")]
    [DisplayName("Second Leg Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegPric")]
    #endif
    [IsoXmlTag("ScndLegPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount SecondLegPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount SecondLegPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount SecondLegPrice { get; init; } 
    #else
    public ActiveCurrencyAndAmount SecondLegPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the dirty price of the underlying security or securities in repo.
    /// </summary>
    [IsoId("_-lqgULboEeaqL_M7XFD7PQ")]
    [DisplayName("Collateral Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMktVal")]
    #endif
    [IsoXmlTag("CollMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralMarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralMarketValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralMarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the counterparty to the repurchase agreement.
    /// </summary>
    [IsoId("_oxf3hbJVEeaYqc4G3TTwhA")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Counterparty { get; init; } 
    #else
    public System.String Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of repurchase agreement.
    /// </summary>
    [IsoId("_3JXU8LJVEeaYqc4G3TTwhA")]
    [DisplayName("Repurchase Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpAgrmtTp")]
    #endif
    [IsoXmlTag("RpAgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #else
    public RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the triparty repurchase agent.
    /// </summary>
    [IsoId("_63_i0LJVEeaYqc4G3TTwhA")]
    [DisplayName("Triparty Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtId")]
    #endif
    [IsoXmlTag("TrptyAgtId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? TripartyAgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentIdentification { get; init; } 
    #else
    public System.String? TripartyAgentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
