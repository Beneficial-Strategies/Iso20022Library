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
/// Account details of the report item.
/// </summary>
[IsoId("_Xtn_QU1oEeSvz4A_x0ui8g")]
[DisplayName("Report Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportItem1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportItem1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportItem1( SecuritiesAccount19 reqAccountIdentification,HoldingAccountLevel1Code reqAccountLevel )
    {
        AccountIdentification = reqAccountIdentification;
        AccountLevel = reqAccountLevel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_xqlbEU1pEeSvz4A_x0ui8g")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 AccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Level of the safekeeping account or sub-account of the report item.
    /// </summary>
    [IsoId("_Qv8mAE1pEeSvz4A_x0ui8g")]
    [DisplayName("Account Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctLvl")]
    #endif
    [IsoXmlTag("AcctLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required HoldingAccountLevel1Code AccountLevel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required HoldingAccountLevel1Code AccountLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldingAccountLevel1Code AccountLevel { get; init; } 
    #else
    public HoldingAccountLevel1Code AccountLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument identification of the report item.
    /// </summary>
    [IsoId("_ia7aAU1pEeSvz4A_x0ui8g")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the report item.
    /// </summary>
    [IsoId("_kotgMU1pEeSvz4A_x0ui8g")]
    [DisplayName("Item Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmDt")]
    #endif
    [IsoXmlTag("ItmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ItemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ItemDate { get; init; } 
    #else
    public System.DateOnly? ItemDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
