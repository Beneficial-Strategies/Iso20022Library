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
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_9h9p68WLEeiRga8tPu1L4Q")]
[DisplayName("Position Set Posted And Received")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetPostedAndReceived1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value posted by the reporting counterparty. 
    /// Usage: This field should include the overall value posted for the portfolio.
    /// </summary>
    [IsoId("_9h9p7MWLEeiRga8tPu1L4Q")]
    [DisplayName("Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pstd")]
    #endif
    [IsoXmlTag("Pstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20Amount? Posted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20Amount? Posted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20Amount? Posted { get; set; } 
    #endif
    
    /// <summary>
    /// Value received by the reporting counterparty. 
    /// Usage: This field should include the overall value received for the portfolio.
    /// </summary>
    [IsoId("_9h9p7cWLEeiRga8tPu1L4Q")]
    [DisplayName("Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvd")]
    #endif
    [IsoXmlTag("Rcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20Amount? Received { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20Amount? Received { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20Amount? Received { get; set; } 
    #endif
    
    
    #nullable disable
    
}
