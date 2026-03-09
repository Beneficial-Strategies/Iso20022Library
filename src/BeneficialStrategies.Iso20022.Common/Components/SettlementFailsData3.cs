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
/// Specifies the aggregated data of settlement fails instructions.
/// </summary>
[IsoId("_afLKcR2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsData3( SettlementTotalData1 reqTotal,SettlementFailureReason3 reqFailureReason )
    {
        Total = reqTotal;
        FailureReason = reqFailureReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total of all types of settlement transactions.
    /// </summary>
    [IsoId("_ahZ_ER2lEeqF2P5v-Rtejg")]
    [DisplayName("Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ttl")]
    #endif
    [IsoXmlTag("Ttl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1 Total { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1 Total { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1 Total { get; init; } 
    #else
    public SettlementTotalData1 Total { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the central securities depositories participants with the highest rates of settlement fails.
    /// </summary>
    [IsoId("_ahZ_Ex2lEeqF2P5v-Rtejg")]
    [DisplayName("Participant In Fail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptInFail")]
    #endif
    [IsoXmlTag("PtcptInFail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsParticipantRange1? ParticipantInFail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsParticipantRange1? ParticipantInFail { get; init; } 
    #else
    public SettlementFailsParticipantRange1? ParticipantInFail { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the settlement fails per currency.
    /// </summary>
    [IsoId("_ahZ_FR2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlsPerCcy")]
    #endif
    [IsoXmlTag("FlsPerCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsCurrency2? FailsPerCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsCurrency2? FailsPerCurrency { get; init; } 
    #else
    public SettlementFailsCurrency2? FailsPerCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the settlement fails per financial instrument type.
    /// </summary>
    [IsoId("_ahZ_Fx2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Financial Instrument Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlsPerFinInstrmTp")]
    #endif
    [IsoXmlTag("FlsPerFinInstrmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsInstrument2? FailsPerFinancialInstrumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsInstrument2? FailsPerFinancialInstrumentType { get; init; } 
    #else
    public SettlementFailsInstrument2? FailsPerFinancialInstrumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the securities with the highest rates of settlement fails.
    /// </summary>
    [IsoId("_ahZ_GR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities In Fail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesInFail")]
    #endif
    [IsoXmlTag("SctiesInFail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsSecuritiesRange1? SecuritiesInFail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsSecuritiesRange1? SecuritiesInFail { get; init; } 
    #else
    public SettlementFailsSecuritiesRange1? SecuritiesInFail { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the settlement fails per transaction type.
    /// </summary>
    [IsoId("_ahZ_Gx2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlsPerTxTp")]
    #endif
    [IsoXmlTag("FlsPerTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsTransactionType2? FailsPerTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsTransactionType2? FailsPerTransactionType { get; init; } 
    #else
    public SettlementFailsTransactionType2? FailsPerTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all types of settlement penalties (such as total of late matching and settlement fails).
    /// </summary>
    [IsoId("_ahZ_HR2lEeqF2P5v-Rtejg")]
    [DisplayName("Total Settlement Penalties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSttlmPnlties")]
    #endif
    [IsoXmlTag("TtlSttlmPnlties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDataVolume2? TotalSettlementPenalties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDataVolume2? TotalSettlementPenalties { get; init; } 
    #else
    public SettlementDataVolume2? TotalSettlementPenalties { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the reason for the settlement fails.
    /// </summary>
    [IsoId("_ahZ_Hx2lEeqF2P5v-Rtejg")]
    [DisplayName("Failure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FailrRsn")]
    #endif
    [IsoXmlTag("FailrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailureReason3 FailureReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailureReason3 FailureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailureReason3 FailureReason { get; init; } 
    #else
    public SettlementFailureReason3 FailureReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
