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
/// Provides information on the settlement of a treasury trade.
/// </summary>
[IsoId("_TJMjldp-Ed-ak6NoX_4Aeg_1219011122")]
[DisplayName("Settlement Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementData2( ActiveOrHistoricCurrencyAndAmount reqSettlementAmount,PartyIdentification8Choice_ reqPayingParty,PartyIdentification8Choice_ reqReceivingParty,System.DateOnly reqSettlementDate,SettlementStatus1Code reqSettlementStatus,System.String reqExtendedSettlementStatus,System.String reqSuspended,System.String reqPending )
    {
        SettlementAmount = reqSettlementAmount;
        PayingParty = reqPayingParty;
        ReceivingParty = reqReceivingParty;
        SettlementDate = reqSettlementDate;
        SettlementStatus = reqSettlementStatus;
        ExtendedSettlementStatus = reqExtendedSettlementStatus;
        Suspended = reqSuspended;
        Pending = reqPending;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference supplied by the trade processing system.
    /// </summary>
    [IsoId("_TJMjltp-Ed-ak6NoX_4Aeg_1219011217")]
    [DisplayName("Cash Flow Unique Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshFlowUnqRef")]
    #endif
    [IsoXmlTag("CshFlowUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashFlowUniqueReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashFlowUniqueReference { get; init; } 
    #else
    public System.String? CashFlowUniqueReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference assigned by a settlement system.
    /// </summary>
    [IsoId("_TJMjl9p-Ed-ak6NoX_4Aeg_1219011546")]
    [DisplayName("Settlement System Unique Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSysUnqRef")]
    #endif
    [IsoXmlTag("SttlmSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SettlementSystemUniqueReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementSystemUniqueReference { get; init; } 
    #else
    public System.String? SettlementSystemUniqueReference { get; set; } 
    #endif
    
    /// <summary>
    /// Original amount which should be settled. This information should be provided when the trade is partially settled or when the settlement is rejected.
    /// </summary>
    [IsoId("_TJMjmNp-Ed-ak6NoX_4Aeg_1219011529")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount SettlementAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Funds which the trading side is expected to receive.
    /// </summary>
    [IsoId("_TJWUkNp-Ed-ak6NoX_4Aeg_1219011494")]
    [DisplayName("Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldAmt")]
    #endif
    [IsoXmlTag("SttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? SettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? SettledAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? SettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that cannot be settled by a settlement system.
    /// </summary>
    [IsoId("_TJWUkdp-Ed-ak6NoX_4Aeg_1219011606")]
    [DisplayName("Rejected Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdAmt")]
    #endif
    [IsoXmlTag("RjctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? RejectedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? RejectedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? RejectedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party that pays the settlement amount.
    /// </summary>
    [IsoId("_TJWUktp-Ed-ak6NoX_4Aeg_1219011900")]
    [DisplayName("Paying Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngPty")]
    #endif
    [IsoXmlTag("PngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ PayingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8Choice_ PayingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ PayingParty { get; init; } 
    #else
    public PartyIdentification8Choice_ PayingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party that receives the settlement amount.
    /// </summary>
    [IsoId("_TJWUk9p-Ed-ak6NoX_4Aeg_1219011959")]
    [DisplayName("Receiving Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgPty")]
    #endif
    [IsoXmlTag("RcvgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ ReceivingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8Choice_ ReceivingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ ReceivingParty { get; init; } 
    #else
    public PartyIdentification8Choice_ ReceivingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the settlement is due to settle.
    /// </summary>
    [IsoId("_TJWUlNp-Ed-ak6NoX_4Aeg_1219011139")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SettlementDate { get; init; } 
    #else
    public System.DateOnly SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a settlement eg rejected, settled or awaiting authorisation.
    /// </summary>
    [IsoId("_TJWUldp-Ed-ak6NoX_4Aeg_1219011157")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStatus1Code SettlementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStatus1Code SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus1Code SettlementStatus { get; init; } 
    #else
    public SettlementStatus1Code SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the status of the settlement of a trade when no coded form is available.
    /// </summary>
    [IsoId("_TJWUltp-Ed-ak6NoX_4Aeg_1219011564")]
    [DisplayName("Extended Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedSttlmSts")]
    #endif
    [IsoXmlTag("XtndedSttlmSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedSettlementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedSettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedSettlementStatus { get; init; } 
    #else
    public System.String ExtendedSettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the cause of the rejection of a settlement.
    /// </summary>
    [IsoId("_TJWUl9p-Ed-ak6NoX_4Aeg_1219011174")]
    [DisplayName("Settlement Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmStsSubTp")]
    #endif
    [IsoXmlTag("SttlmStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SettlementStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementStatusSubType { get; init; } 
    #else
    public System.String? SettlementStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Cash settlement is suspended.
    /// </summary>
    [IsoId("_TJWUmNp-Ed-ak6NoX_4Aeg_1219011234")]
    [DisplayName("Suspended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspd")]
    #endif
    [IsoXmlTag("Sspd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Suspended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Suspended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Suspended { get; init; } 
    #else
    public System.String Suspended { get; set; } 
    #endif
    
    /// <summary>
    /// Cash settlement is pending.
    /// </summary>
    [IsoId("_TJWUmdp-Ed-ak6NoX_4Aeg_1219011469")]
    [DisplayName("Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdg")]
    #endif
    [IsoXmlTag("Pdg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Pending { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Pending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Pending { get; init; } 
    #else
    public System.String Pending { get; set; } 
    #endif
    
    
    #nullable disable
    
}
