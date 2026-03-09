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
/// Provides details on the tranches defined for the loan contract.
/// </summary>
[IsoId("_3sV2tNNDEeSDLevdaFPXHw")]
[DisplayName("Loan Contract Tranche")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanContractTranche1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanContractTranche1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanContractTranche1( System.UInt64 reqTrancheNumber,System.DateOnly reqExpectedDate,ActiveCurrencyAndAmount reqAmount )
    {
        TrancheNumber = reqTrancheNumber;
        ExpectedDate = reqExpectedDate;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique sequence number of the tranche.
    /// </summary>
    [IsoId("_3sV2tdNDEeSDLevdaFPXHw")]
    [DisplayName("Tranche Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrchNb")]
    #endif
    [IsoXmlTag("TrchNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TrancheNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TrancheNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TrancheNumber { get; init; } 
    #else
    public System.UInt64 TrancheNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Expected tranche payment date.
    /// </summary>
    [IsoId("_FdOzsNNEEeSDLevdaFPXHw")]
    [DisplayName("Expected Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdDt")]
    #endif
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ExpectedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ExpectedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ExpectedDate { get; init; } 
    #else
    public System.DateOnly ExpectedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the tranche as defined in the loan contract.
    /// </summary>
    [IsoId("_JBwDUNNEEeSDLevdaFPXHw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Loan tranche due date.
    /// </summary>
    [IsoId("_mz8FotOEEeSQ_-lmj1tzfw")]
    [DisplayName("Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueDt")]
    #endif
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DueDate { get; init; } 
    #else
    public System.DateOnly? DueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Loan tranche duration in a coded form.
    /// </summary>
    [IsoId("_8Ty5cdOEEeSQ_-lmj1tzfw")]
    [DisplayName("Duration Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrtnCd")]
    #endif
    [IsoXmlTag("DrtnCd")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? DurationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DurationCode { get; init; } 
    #else
    public System.String? DurationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether this tranche is the last tranche of the full report.
    /// </summary>
    [IsoId("_3sV2ttNDEeSDLevdaFPXHw")]
    [DisplayName("Last Tranche Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastTrchInd")]
    #endif
    [IsoXmlTag("LastTrchInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LastTrancheIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastTrancheIndicator { get; init; } 
    #else
    public System.String? LastTrancheIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
