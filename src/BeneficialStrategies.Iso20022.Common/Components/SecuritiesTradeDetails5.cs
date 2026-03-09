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
/// Details of the securities trade.
/// </summary>
[IsoId("_S8PFsNp-Ed-ak6NoX_4Aeg_35599121")]
[DisplayName("Securities Trade Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTradeDetails5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeDetails5( DateAndDateTimeChoice_ reqOpeningSettlementDate )
    {
        OpeningSettlementDate = reqOpeningSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S8PFsdp-Ed-ak6NoX_4Aeg_511209995")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_S8PFstp-Ed-ak6NoX_4Aeg_35599481")]
    [DisplayName("Opening Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngSttlmDt")]
    #endif
    [IsoXmlTag("OpngSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ OpeningSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ OpeningSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ OpeningSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ OpeningSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_S8PFs9p-Ed-ak6NoX_4Aeg_35599541")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_S8Y2oNp-Ed-ak6NoX_4Aeg_35599966")]
    [DisplayName("Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
