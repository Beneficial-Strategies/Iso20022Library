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
/// Information about a switch leg that is rejected or repaired.
/// </summary>
[IsoId("_Fx2LRTbtEead9bDRE_1DAQ")]
[DisplayName("Switch Leg References")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchLegReferences2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchLegReferences2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchLegReferences2( LegIdentification1Choice_ reqLegIdentification )
    {
        LegIdentification = reqLegIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a switch leg.
    /// </summary>
    [IsoId("_pWQb0EglEea9YuSvQGoi-w")]
    [DisplayName("Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegId")]
    #endif
    [IsoXmlTag("LegId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LegIdentification1Choice_ LegIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LegIdentification1Choice_ LegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegIdentification1Choice_ LegIdentification { get; init; } 
    #else
    public LegIdentification1Choice_ LegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the reason for the rejection of the leg.
    /// </summary>
    [IsoId("_GKGTFzbtEead9bDRE_1DAQ")]
    [DisplayName("Leg Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegRjctnRsn")]
    #endif
    [IsoXmlTag("LegRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? LegRejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegRejectionReason { get; init; } 
    #else
    public System.String? LegRejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_KVakgUgmEea9YuSvQGoi-w")]
    [DisplayName("Repaired Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdFee")]
    #endif
    [IsoXmlTag("RprdFee")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Fee3> RepairedFee { get; init; } = new ValueList<Fee3>(){};
    
    /// <summary>
    /// Account identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_GKGTGzbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount58? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_GKGTHTbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument57? FinancialInstrumentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
