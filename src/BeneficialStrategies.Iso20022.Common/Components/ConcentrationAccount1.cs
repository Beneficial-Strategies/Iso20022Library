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
/// Bank account used by a central counterparty to concentrate cash funds before or after investment.
/// </summary>
[IsoId("_tnsvELIhEeaYqc4G3TTwhA")]
[DisplayName("Concentration Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConcentrationAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConcentrationAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConcentrationAccount1( Flows1 reqInFlow,Flows1 reqOutFlow,AmountAndDirection102 reqEndOfDay,ActiveCurrencyAndAmount reqPeakCredit,ActiveCurrencyAndAmount reqPeakDebit,System.String reqLatePaymentConfirmation )
    {
        InFlow = reqInFlow;
        OutFlow = reqOutFlow;
        EndOfDay = reqEndOfDay;
        PeakCredit = reqPeakCredit;
        PeakDebit = reqPeakDebit;
        LatePaymentConfirmation = reqLatePaymentConfirmation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates inflows into the account.
    /// </summary>
    [IsoId("_zPbzoLIhEeaYqc4G3TTwhA")]
    [DisplayName("In Flow")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InFlow")]
    #endif
    [IsoXmlTag("InFlow")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Flows1 InFlow { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Flows1 InFlow { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Flows1 InFlow { get; init; } 
    #else
    public Flows1 InFlow { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates outflows out of the account.
    /// </summary>
    [IsoId("_0TkxMLIhEeaYqc4G3TTwhA")]
    [DisplayName("Out Flow")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutFlow")]
    #endif
    [IsoXmlTag("OutFlow")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Flows1 OutFlow { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Flows1 OutFlow { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Flows1 OutFlow { get; init; } 
    #else
    public Flows1 OutFlow { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates end of day cash balance on the account.
    /// </summary>
    [IsoId("_1ym0QBXoEeejf-cbr8l5qw")]
    [DisplayName("End Of Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDay")]
    #endif
    [IsoXmlTag("EndOfDay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDay { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDay { get; init; } 
    #else
    public AmountAndDirection102 EndOfDay { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates peak credit balance on the account.
    /// </summary>
    [IsoId("_53fmABXoEeejf-cbr8l5qw")]
    [DisplayName("Peak Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PeakCdt")]
    #endif
    [IsoXmlTag("PeakCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PeakCredit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PeakCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PeakCredit { get; init; } 
    #else
    public ActiveCurrencyAndAmount PeakCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates peak debit balance on the account.
    /// </summary>
    [IsoId("_-YlLkBXoEeejf-cbr8l5qw")]
    [DisplayName("Peak Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PeakDbt")]
    #endif
    [IsoXmlTag("PeakDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PeakDebit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PeakDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PeakDebit { get; init; } 
    #else
    public ActiveCurrencyAndAmount PeakDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of concentration account pay‐ins breaching the allowed time between instruction and confirmation. Usage: nil returns to be included for late payment confirmations in all cleared currencies.
    /// </summary>
    [IsoId("_Frc8QBXpEeejf-cbr8l5qw")]
    [DisplayName("Late Payment Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatePmtConf")]
    #endif
    [IsoXmlTag("LatePmtConf")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10NumericText LatePaymentConfirmation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LatePaymentConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LatePaymentConfirmation { get; init; } 
    #else
    public System.String LatePaymentConfirmation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
