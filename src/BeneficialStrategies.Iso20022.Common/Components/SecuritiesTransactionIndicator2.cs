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
/// Provides additional indicators on the transaction.
/// </summary>
[IsoId("_ZVa-kGhoEeaqBY_HJicULw")]
[DisplayName("Securities Transaction Indicator")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTransactionIndicator2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTransactionIndicator2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTransactionIndicator2( System.String reqSecuritiesFinancingTransactionIndicator )
    {
        SecuritiesFinancingTransactionIndicator = reqSecuritiesFinancingTransactionIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction was executed under a pre-trade waiver.
    /// </summary>
    [IsoId("_ZmkY8WhoEeaqBY_HJicULw")]
    [DisplayName("Waiver Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WvrInd")]
    #endif
    [IsoXmlTag("WvrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingWaiverType1Code? WaiverIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingWaiverType1Code? WaiverIndicator { get; init; } 
    #else
    public ReportingWaiverType1Code? WaiverIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a short sell concluded by the investment agent on its own accounts or on behalf of a client, as described in the local regulation.
    /// </summary>
    [IsoId("_ZmkY82hoEeaqBY_HJicULw")]
    [DisplayName("Short Selling Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtSellgInd")]
    #endif
    [IsoXmlTag("ShrtSellgInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Side5Code? ShortSellingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side5Code? ShortSellingIndicator { get; init; } 
    #else
    public Side5Code? ShortSellingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of transaction in accordance with the local regulation.
    /// </summary>
    [IsoId("_ZmkY9WhoEeaqBY_HJicULw")]
    [DisplayName("OTC Post Trade Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OTCPstTradInd")]
    #endif
    [IsoXmlTag("OTCPstTradInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingWaiverType3Code? OTCPostTradeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingWaiverType3Code? OTCPostTradeIndicator { get; init; } 
    #else
    public ReportingWaiverType3Code? OTCPostTradeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is objectively measurable as reducing risks directly relating to the commercial activity of the entity executing the transaction.
    /// </summary>
    [IsoId("_ZmkY92hoEeaqBY_HJicULw")]
    [DisplayName("Risk Reducing Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskRdcgTx")]
    #endif
    [IsoXmlTag("RskRdcgTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RiskReducingTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RiskReducingTransaction { get; init; } 
    #else
    public System.String? RiskReducingTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction falls within the scope of activity to be reported under the Securities Financing Transactions Regulation.
    /// </summary>
    [IsoId("_ZmkY-WhoEeaqBY_HJicULw")]
    [DisplayName("Securities Financing Transaction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTxInd")]
    #endif
    [IsoXmlTag("SctiesFincgTxInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator SecuritiesFinancingTransactionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecuritiesFinancingTransactionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecuritiesFinancingTransactionIndicator { get; init; } 
    #else
    public System.String SecuritiesFinancingTransactionIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
