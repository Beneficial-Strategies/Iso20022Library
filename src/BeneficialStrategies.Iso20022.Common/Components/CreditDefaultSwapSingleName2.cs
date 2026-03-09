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
/// Credit default swap derivative specific for reporting on a single name credit default swap.
/// </summary>
[IsoId("_NmrxeX5fEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Single Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditDefaultSwapSingleName2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditDefaultSwapSingleName2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditDefaultSwapSingleName2( System.String reqSovereignIssuer,string reqNotionalCurrency )
    {
        SovereignIssuer = reqSovereignIssuer;
        NotionalCurrency = reqNotionalCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name CDS.
    /// </summary>
    [IsoId("_NvBOEX5fEea2k7EBUopqxw")]
    [DisplayName("Sovereign Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrgnIssr")]
    #endif
    [IsoXmlTag("SvrgnIssr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator SovereignIssuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SovereignIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SovereignIssuer { get; init; } 
    #else
    public System.String SovereignIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
    /// </summary>
    [IsoId("_NvBOE35fEea2k7EBUopqxw")]
    [DisplayName("Reference Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPty")]
    #endif
    [IsoXmlTag("RefPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    #else
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_NvBOFX5fEea2k7EBUopqxw")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string NotionalCurrency { get; init; } 
    #else
    public string NotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
