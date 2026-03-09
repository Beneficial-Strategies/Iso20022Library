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
[IsoId("_Be9ioZQCEeiILOjNP8ro1w")]
[DisplayName("Counterparty Specific Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartySpecificData21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartySpecificData21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartySpecificData21( TradeCounterpartyReport8 reqCounterparty,System.DateTime reqReportingDateTime )
    {
        Counterparty = reqCounterparty;
        ReportingDateTime = reqReportingDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_BrzEwZQCEeiILOjNP8ro1w")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyReport8 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCounterpartyReport8 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyReport8 Counterparty { get; init; } 
    #else
    public TradeCounterpartyReport8 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_BrzEw5QCEeiILOjNP8ro1w")]
    [DisplayName("Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Valtn")]
    #endif
    [IsoXmlTag("Valtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractValuationData3? Valuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractValuationData3? Valuation { get; init; } 
    #else
    public ContractValuationData3? Valuation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_BrzExZQCEeiILOjNP8ro1w")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCollateralReport2? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCollateralReport2? Collateral { get; init; } 
    #else
    public TradeCollateralReport2? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of reporting to the trade repository as required by regulation.
    /// </summary>
    [IsoId("_BrzEx5QCEeiILOjNP8ro1w")]
    [DisplayName("Reporting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDtTm")]
    #endif
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReportingDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ReportingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReportingDateTime { get; init; } 
    #else
    public System.DateTime ReportingDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
