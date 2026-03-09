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
/// Data related specifically to counterparties.
/// </summary>
[IsoId("_nQXxmXg-Eeu3kecHd7QKUQ")]
[DisplayName("Counterparty Specific Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartySpecificData29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartySpecificData29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartySpecificData29( TradeCounterpartyReport14 reqCounterparty,System.DateTime reqReportingTimeStamp )
    {
        Counterparty = reqCounterparty;
        ReportingTimeStamp = reqReportingTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_ne8ZEXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyReport14 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCounterpartyReport14 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyReport14 Counterparty { get; init; } 
    #else
    public TradeCounterpartyReport14 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_ne8ZE3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Valtn")]
    #endif
    [IsoXmlTag("Valtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractValuationData6? Valuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractValuationData6? Valuation { get; init; } 
    #else
    public ContractValuationData6? Valuation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// Usage: This element is not present when there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_ne8ZFXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCollateralReport5? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCollateralReport5? Collateral { get; init; } 
    #else
    public TradeCollateralReport5? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    [IsoId("_ne8ZF3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Reporting Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgTmStmp")]
    #endif
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReportingTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ReportingTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReportingTimeStamp { get; init; } 
    #else
    public System.DateTime ReportingTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
