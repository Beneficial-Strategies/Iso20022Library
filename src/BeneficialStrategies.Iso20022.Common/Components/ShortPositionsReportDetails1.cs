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
/// Information about short positions.
/// </summary>
[IsoId("_shPDYAx3EeazkbJaoKTIIw")]
[DisplayName("Short Positions Report Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShortPositionsReportDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ShortPositionsReportDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShortPositionsReportDetails1( BranchAndFinancialInstitutionIdentification5 reqParticipantIdentification,CashAccount24 reqParticipantAccount,ActiveCurrencyAndAmount reqShortPositionAmount )
    {
        ParticipantIdentification = reqParticipantIdentification;
        ParticipantAccount = reqParticipantAccount;
        ShortPositionAmount = reqShortPositionAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of participant account.
    /// </summary>
    [IsoId("_CJhacAx4EeazkbJaoKTIIw")]
    [DisplayName("Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptId")]
    #endif
    [IsoXmlTag("PtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 ParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 ParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 ParticipantIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 ParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information about participant account number.
    /// </summary>
    [IsoId("_EJegAAx4EeazkbJaoKTIIw")]
    [DisplayName("Participant Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptAcct")]
    #endif
    [IsoXmlTag("PtcptAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount24 ParticipantAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount24 ParticipantAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24 ParticipantAccount { get; init; } 
    #else
    public CashAccount24 ParticipantAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information about participant account balance.
    /// </summary>
    [IsoId("_Hri4kAx4EeazkbJaoKTIIw")]
    [DisplayName("Short Position Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtPosAmt")]
    #endif
    [IsoXmlTag("ShrtPosAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ShortPositionAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ShortPositionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ShortPositionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ShortPositionAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
