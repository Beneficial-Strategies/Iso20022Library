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
/// Provides information about the global distribution.
/// </summary>
[IsoId("_UKdzVdp-Ed-ak6NoX_4Aeg_-227934218")]
[DisplayName("Global Distribution Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GlobalDistributionRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GlobalDistributionRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GlobalDistributionRequest1( System.String reqPreadviceIndicator,System.String reqOptionNumber,CorporateActionOption1FormatChoice_ reqOptionType,DateFormat4Choice_ reqRecordDate,DateFormat4Choice_ reqPaymentDate )
    {
        PreadviceIndicator = reqPreadviceIndicator;
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        RecordDate = reqRecordDate;
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates wether is message is an advice or pre-advice.
    /// </summary>
    [IsoId("_UKdzVtp-Ed-ak6NoX_4Aeg_-2123921749")]
    [DisplayName("Preadvice Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PradvcInd")]
    #endif
    [IsoXmlTag("PradvcInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PreadviceIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PreadviceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PreadviceIndicator { get; init; } 
    #else
    public System.String PreadviceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UKdzV9p-Ed-ak6NoX_4Aeg_85141205")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OptionNumber { get; init; } 
    #else
    public System.String OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UKdzWNp-Ed-ak6NoX_4Aeg_85141236")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the holders of securities are/will be recorded for the income being paid or for entitlement to the rights or offer/privilege.
    /// </summary>
    [IsoId("_UKdzWdp-Ed-ak6NoX_4Aeg_177913801")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat4Choice_ RecordDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat4Choice_ RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_ RecordDate { get; init; } 
    #else
    public DateFormat4Choice_ RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which securities/cash will be paid.
    /// </summary>
    [IsoId("_UKdzWtp-Ed-ak6NoX_4Aeg_221318375")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat4Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat4Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat4Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securities movement.
    /// </summary>
    [IsoId("_UKdzW9p-Ed-ak6NoX_4Aeg_1979460314")]
    [DisplayName("Securities Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmnt")]
    #endif
    [IsoXmlTag("SctiesMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityMovement1? SecuritiesMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityMovement1? SecuritiesMovement { get; init; } 
    #else
    public SecurityMovement1? SecuritiesMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash movement.
    /// </summary>
    [IsoId("_UKnkUNp-Ed-ak6NoX_4Aeg_1970224157")]
    [DisplayName("Cash Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmnt")]
    #endif
    [IsoXmlTag("CshMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement1? CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement1? CashMovement { get; init; } 
    #else
    public CashMovement1? CashMovement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
